using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [Range(1, 2)]
    [SerializeField] private int controllerNumber;

    public int GetControllerNumber() => controllerNumber;

    
    public void SetControllerNumber(int newControllerNumber)
    {
        if (newControllerNumber == 1 || newControllerNumber == 2)
        {
            controllerNumber = newControllerNumber;
        }
    }
    
    public Vector2 GetLeftStickVector()
    {
        float xAxis = 1; //Input.GetAxisRaw("LeftStickHorizontal" + controllerNumber);         //FIX THIS PLEAASEE
        float yAxis = 1; // Input.GetAxisRaw("LeftStickVertical"   + controllerNumber);

        Vector2 leftStickInput = new Vector2(xAxis, yAxis);

        if (leftStickInput.magnitude < 0.2f) { return Vector2.zero; }

        return leftStickInput;
    }
}
