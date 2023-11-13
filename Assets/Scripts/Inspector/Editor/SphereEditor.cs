using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Inspector
{
    [CustomEditor(typeof(Sphere))]
    public class SphereEditor : Editor
    {
        private const string RadiusField = "_radius";
        
        public override void OnInspectorGUI()
        {
            Sphere sphere = (Sphere)target;

            GUILayout.BeginHorizontal();
            
            UpdateSphereRadius(sphere);
            DrawResetButton(sphere);
            
            GUILayout.EndHorizontal();
        }

        private void UpdateSphereRadius(Sphere sphere)
        {
            float radius = DrawRadiusSlider(sphere);
            
            GetRadiusField(sphere).SetValue(sphere, radius);

            sphere.transform.localScale = Vector3.one * radius;
        }

        private float DrawRadiusSlider(Sphere sphere)
        {
            float radius = (float) GetRadiusField(sphere).GetValue(sphere);
            radius = EditorGUILayout.Slider("Radius", radius, 0.01f, 5f);
            return radius;
        }

        private void DrawResetButton(Sphere sphere)
        {
            if (GUILayout.Button("Reset"))
                GetRadiusField(sphere).SetValue(sphere, 1f);
        }

        private FieldInfo GetRadiusField(Sphere sphere)
        {
            return sphere.GetType().GetField(RadiusField, BindingFlags.Instance | BindingFlags.NonPublic);
        }
    }
}