using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Cube myTarget = (Cube)target;

        myTarget.prefabCube = (GameObject)EditorGUILayout.ObjectField(myTarget.prefabCube, typeof(GameObject), true);
        myTarget.cubeSize = EditorGUILayout.Vector3Field("Tamanho do Cubo", myTarget.cubeSize);

        if (GUILayout.Button("Create Cube"))
        {
            myTarget.CreateCube();
        }
    }
}
