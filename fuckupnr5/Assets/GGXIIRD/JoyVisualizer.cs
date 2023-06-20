using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[ExecuteAlways] public class JoyVisualizer : MonoBehaviour
{
    [SerializeField] Transform[] dots; //Should be either 9 positions or 8
    //1 2 3
    //4 5 6
    //7 8 9
    LineRenderer line;
    [SerializeField] Canvas       canvas;

    void Awake()
    {
        line   = GetComponentInChildren<LineRenderer>();
        canvas = GetComponent<Canvas>();
    }
    void Update()
    {
        
    }
    public void AddToJoy(int value)
    {
        var     a = line.positionCount++;

        Vector3 b = new Vector3(dots[value].position.x * canvas.referencePixelsPerUnit,
                                dots[value].position.y * canvas.referencePixelsPerUnit - 100);
        line.SetPosition(a, b);
    }

    public void ResetJoy() => line.positionCount = 0;

}
