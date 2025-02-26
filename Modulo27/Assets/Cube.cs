using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject prefabCube;

    public Vector3 cubeSize;

    public void CreateCube()
    {
        var obj = Instantiate(prefabCube, Vector3.zero, Quaternion.identity);
        obj.transform.localScale = cubeSize;
    }
}
