using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Inspector
{
    [CustomEditor(typeof(Sphere))]
    public class SphereEditor : Editor
    {
        private const string RadiusField = "_radius";
        private const string SliderFieldLabel = "Radius";
        private const float MinSliderValue = 0.01f;
        private const float MaxSliderValue = 5f;
        private const string ResetButtonText = "Reset";
        private const float DefaultRadius = 1f;
        
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
            FieldInfo radiusField = sphere.GetType().GetField(RadiusField, BindingFlags.Instance | BindingFlags.NonPublic);
            float radius = (float) radiusField.GetValue(sphere);

            radius = EditorGUILayout.Slider(SliderFieldLabel, radius, MinSliderValue, MaxSliderValue);
            radiusField.SetValue(sphere, radius);
            sphere.transform.localScale = Vector3.one * radius;
        }

        private void DrawResetButton(Sphere sphere)
        {
            if (GUILayout.Button(ResetButtonText))
                sphere.ResetRadius();
        }
    }
}