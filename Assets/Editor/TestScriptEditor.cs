using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(TestScript))]
public class TestScriptEditor : Editor
{
    public override VisualElement CreateInspectorGUI()
    {
        Debug.Log("loaded uss " + DateTime.Now.Ticks);
        StyleSheet styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/custom-base-field.uss");
        VisualTreeAsset uiTemplate = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/custom-base-field-layout.uxml");
        VisualElement root = uiTemplate.Instantiate();
        root.styleSheets.Add(styleSheet);
        return root;
        
        Debug.Log("loaded uss " + DateTime.Now.Ticks);
        
        // Create a new VisualElement to be the root of our inspector UI
        VisualElement myInspector = new VisualElement();
        myInspector.styleSheets.Add(styleSheet);

        IntegerField integerField = new IntegerField("Unity integer field", 10);
        
        myInspector.Add(integerField);
        
        VisualElement container = new VisualElement() { name = "container"};
        container.AddToClassList("custom-unity-field-container");

        Label label = new Label("Custom integer field");
        label.AddToClassList("custom-unity-field-label");

        IntegerField valueField = new IntegerField();
        valueField.AddToClassList("custom-unity-field-value");
        
        container.Add(label);
        container.Add(valueField);
        
        myInspector.Add(container);
        
        // Return the finished inspector UI
        return myInspector;
    }
}
