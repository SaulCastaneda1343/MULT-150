using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // This keeps track of how many times the sphere hits the cube
    int bounceCount = 0;

    // This happens when the sphere bumps into the cube (using Collider)
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object hitting the cube is the sphere
        if (collision.gameObject.tag == "Sphere")
        {
            bounceCount++;
            Debug.Log("The sphere has bounced " + bounceCount + " times!");
        }
    }

    // This happens if you're using a Trigger instead of a normal Collider
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sphere")
        {
            bounceCount++;
            Debug.Log("The sphere has bounced (trigger) " + bounceCount + " times!");
        }
    }
}