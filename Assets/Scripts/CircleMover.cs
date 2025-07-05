using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool ifDownIsPressed = Input.GetKeyDown(KeyCode.DownArrow);

        Vector3 newDownPosition = transform.position - Vector3.up * 0.1f;

        if (ifDownIsPressed)
        {
            transform.position = newDownPosition;
        }

        bool ifUpIsPressed = Input.GetKeyUp(KeyCode.UpArrow);

        Vector3 newUpPosition = transform.position + Vector3.up * 0.1f;

        if (ifUpIsPressed)
        {
            transform.position = newUpPosition;
        }

        bool ifRightIsPressed = Input.GetKey(KeyCode.RightArrow);

        Vector3 newRightPosition = transform.position + Vector3.right * 0.5f;

        if (ifRightIsPressed)
        {
            transform.position = newRightPosition;
        }

        bool ifLeftIsPresssed = Input.GetKeyDown(KeyCode.LeftArrow);

        Vector3 newLeftPosition = transform.position + Vector3.left * 0.5f;

        if (ifLeftIsPresssed)
        {
            transform.position = newLeftPosition;
        }


    }
}
