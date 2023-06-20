using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyTester : MonoBehaviour
{
    [SerializeField] int num;
    JoyVisualizer        joy;
    void                 Awake() => joy = FindObjectOfType<JoyVisualizer>();
    public void Aaa()
    {
        joy.AddToJoy(num);
    }
    public void Bbb()
    {
        joy.ResetJoy();
    }
}
