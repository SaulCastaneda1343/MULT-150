using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycastscript : MonoBehaviour
{
    void Update()
    {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");

        // opposite because we rotate about those axes
        transform.Rotate(dirY, -dirX, 0);

        CheckForRaycastHit(); // this checks for raycast collisions
    }

    void CheckForRaycastHit()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            print(hit.collider.gameObject.name + " destroyed!");
            Destroy(hit.collider.gameObject);
        }
    }
}