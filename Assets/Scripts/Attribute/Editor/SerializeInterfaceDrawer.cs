using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

[CustomPropertyDrawer(typeof(SerializeInterfaceAttribute))]
public class SerializeInterfaceDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (IsFieldValid() == false)
        {
            DrawError(position);
            return;
        }

        Type requiredType = (attribute as SerializeInterfaceAttribute).Type;

        UpdateDropIcon(position, requiredType);
        UpdatePropertyValues(property, requiredType);
        DrawField(position, property, label, requiredType);
    }

    private bool IsFieldValid()
    {
        return fieldInfo.FieldType == typeof(GameObject) || typeof(IEnumerable<GameObject>).IsAssignableFrom(fieldInfo.FieldType);
    }

    private void DrawError(Rect position)
    {
        EditorGUI.HelpBox(
            position,
            "SerializeInterfaceAttribute works only with Object type from Unity",
            MessageType.Error);
    }

    private void UpdateDropIcon(Rect position, Type requiredType)
    {
        if (position.Contains(Event.current.mousePosition) == false)
            return;

        foreach (Object reference in DragAndDrop.objectReferences)
        {
            if (IsValidObject(reference, requiredType) == false)
            {
                DragAndDrop.visualMode = DragAndDropVisualMode.Rejected;
                break;
            }
        }
    }

    private bool IsValidObject(Object @object, Type requiredType)
    {
        if (@object is GameObject gameObject)
            return gameObject.GetComponent(requiredType) != null;

        return false;
    }

    private void  UpdatePropertyValues(SerializedProperty property, Type requiredType)
    {
        if (property.objectReferenceValue == null)
            return;

        if (IsValidObject(property.objectReferenceValue, requiredType) == false)
            property.objectReferenceValue = null;
    }

    private void DrawField(Rect position, SerializedProperty property, GUIContent label, Type type)
    {
        property.objectReferenceValue = EditorGUI.ObjectField(position, label, property.objectReferenceValue, typeof(Object), true);
    }
}
