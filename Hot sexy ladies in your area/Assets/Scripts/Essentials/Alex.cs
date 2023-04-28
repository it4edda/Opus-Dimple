using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

namespace AlexEssentials
{
    public class ReadOnlyAttribute : PropertyAttribute
    { }

    /// <summary>
    ///     Allows you to add '[ReadOnly]' before a variable so that it is shown but not editable in the inspector.
    ///     Small but useful script, to make your inspectors look pretty and useful 😄
    ///     <example> [SerializedField, ReadOnly] int myInt; </example>
    /// </summary>
    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public class TestPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;
            EditorGUI.PropertyField(position, property, label);
            GUI.enabled = true;
        }
    }   
}

