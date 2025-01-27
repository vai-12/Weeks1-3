using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeTrackingScript : MonoBehaviour
{
    // The center of the eyeball
    public Transform eyeCenter;
    // The maximum distance the eyeball can move
    public float radius = 0.1f;


    void Update()
    {
        // Get access to the mouse position
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        // Calculate the distance from the center of the eyeball to the mouse
        Vector3 direction = (mousePos - eyeCenter.position).normalized;
        
        // Limit the eyes position to move within a certain radius
        transform.position = eyeCenter.position + direction * Mathf.Min(radius, Vector3.Distance(mousePos, eyeCenter.position));
    }
}
