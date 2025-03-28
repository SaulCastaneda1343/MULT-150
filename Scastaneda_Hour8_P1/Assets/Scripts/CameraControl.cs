using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    void Update()
    {
        float moveX = Input.GetAxis("Mouse X");
        float moveY = Input.GetAxis("Mouse Y");

        // Translate camera based on mouse movement
        transform.Translate(moveX, moveY, 0f);
    }
}
