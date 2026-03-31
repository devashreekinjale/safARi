using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithButtons : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private int direction = 0;

    void Update()
    {
        if (direction != 0)
        {
            transform.Rotate(0f, direction * rotationSpeed * Time.deltaTime, 0f);
        }
    }

    // Called when LEFT button is pressed
    public void RotateLeftDown()
    {
        direction = 1;
    }

    // Called when RIGHT button is pressed
    public void RotateRightDown()
    {
        direction = -1;
    }

    // Called when button is released
    public void StopRotation()
    {
        direction = 0;
    }
}