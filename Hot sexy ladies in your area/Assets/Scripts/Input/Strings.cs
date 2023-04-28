using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine;
using AlexEssentials;

public class Strings : MonoBehaviour
{
    [SerializeField, Range(1, 2),Header( "Player Related")]  int     player;
    [SerializeField, Range(1, 2), Header("Whammy Related")]  float   whammy       = 1f;
    [SerializeField]                                         int     points       = 1;
    [SerializeField]                                         float   minAmplitude = 1f;
    [SerializeField]                                         float   maxAmplitude = 2f;
    [SerializeField,  AlexEssentials.ReadOnly]               float   amplitude;
    [SerializeField]                                         float   frequency     = 1f;
    [SerializeField]                                         float   movementSpeed = 1f;
    [SerializeField]                                         Vector2 xLimits       = new Vector2(0, 1);

    LineRenderer gString;
    PlayerInput input;

    void Start()
    {
        gString = GetComponent<LineRenderer>();
        input   = GetComponent<PlayerInput>();
    }
    void Update()
    {
        whammy = input.GetLeftStickVector().x;
        //Vet inte om denna raden är som den ska vara, fråga nils
        amplitude = Mathf.Clamp(whammy, minAmplitude, maxAmplitude); 
        Draw();
    }



    void Draw()
    {
        float xStart  = xLimits.x; //0;
        float tau     = 2 * Mathf.PI;
        float xFinish = xLimits.y; //tau;
        gString.positionCount = points;

        for (var currentPoint = 0; currentPoint<points; currentPoint++)
        {
            float progress = (float) currentPoint / (points - 1);
            float x        = Mathf.Lerp(xStart, xFinish, progress);
            float y        = amplitude * Mathf.Sin((frequency * tau * x) + (movementSpeed * Time.timeSinceLevelLoad));
            gString.SetPosition(currentPoint, new Vector3(x, y,0));

        }
    }
}
