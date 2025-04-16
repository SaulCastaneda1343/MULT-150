using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992; // This goes above Start()

    void Start()
    {
        // UsePotion calls — spammed 4 times
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

        // Log final healthpoints
        Debug.Log("Final Health Points: " + healthpoints); // Should be 5192
    }

    void Update()
    {
        // Usually used for frame updates, left empty here
    }

    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}
