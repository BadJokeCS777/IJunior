using UnityEditor;
using UnityEngine;

namespace Window
{
    public class ColorizerWindow : EditorWindow
    {
        private Color _color = Color.white;
        
        [MenuItem("Window/Colorizer")]
        public static void ShowWindow()
        {
            GetWindow<ColorizerWindow>("Colorizer");
        }

        private void OnGUI()
        {
            GUILayout.Label("Color the selected objects", EditorStyles.boldLabel);

            _color = EditorGUILayout.ColorField("Color", _color);

            if (GUILayout.Button("Colorize"))
                Colorize();
        }

        private void Colorize()
        {
            foreach (GameObject gameObject in Selection.gameObjects)
            {
                Renderer renderer = gameObject.GetComponent<Renderer>();

                if (renderer != null)
                {
                    renderer.sharedMaterial.color = _color;
                }
            }
        }
    }
}
