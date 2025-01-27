using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotationScript : MonoBehaviour
{
    // This is the speed of rotation
    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotate the head based on input, A/D or left/right keys
        float input = Input.GetAxis("Horizontal");
        transform.Rotate(0f, 0f, -input * rotationSpeed * Time.deltaTime);
    }
}
