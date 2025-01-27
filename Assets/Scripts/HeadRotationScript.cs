using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotationScript : MonoBehaviour
{
    // This is the speed of rotation
    public float rotationSpeed = 100f;
    
    // Key bindings for left and right rotation
    public KeyCode rotateLeftKey = KeyCode.A;
    public KeyCode rotateRightKey = KeyCode.D;

    void Update()
    {
        // Initialize rotation
        float input = 0f;

        // Check if the left rotation key or right rotation key is pressed
        if (Input.GetKey(rotateLeftKey))
        {
            // Rotate head counterclockwise
            input = -1f; 
        }

        else if (Input.GetKey(rotateRightKey))
        {  
            // Rotate head clockwise
            input = 1f;
        }

        // Apply the rotation
        transform.Rotate(0f, 0f, input * rotationSpeed * Time.deltaTime);
    }
    
}