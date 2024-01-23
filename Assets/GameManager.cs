using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Level(int score)
    {
        int defaultSpeed = -5;
        int increSpeed = (score * -1) / 100;

        if (increSpeed < -5)
            increSpeed = -5;

        return defaultSpeed + increSpeed;
    }

    //[InitializeOnEnterPlayMode]
    //public static void DisableCodebaseWarnings()
    //{
    //    Debug.unityLogger.logEnabled = false;
    //    var _ = Codebase.assemblies;
    //    Debug.unityLogger.logEnabled = true;
    //}
}
