using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class Utils
{
    #if UNITY_EDITOR
    [UnityEditor.MenuItem("Utils/Create Cube")]
    public static void CreateCube()
    {
        var obj = MonoBehaviour.Instantiate(Resources.Load("Cube"), Vector3.zero, Quaternion.identity);
    }
    #endif

    public static T GetRandom<T>(this T[] array)
    {
        if (array.Length == 1)
        {
            return default(T);
        }

        return array[Random.Range(0, array.Length)];
    }

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
}
