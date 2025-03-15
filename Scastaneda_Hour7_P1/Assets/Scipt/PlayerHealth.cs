using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Declare and assign float variables
        float health = 1004f;
        float poisonDamage = 125.5f;

        // Print initial health
        print(health);

        // Repeatedly subtract poisonDamage until health reaches 0
        while (health > 0)
        {
            // Subtract poisonDamage from health
            health -= poisonDamage;

            // Ensure health does not go below 0
            if (health < 0)
            {
                health = 0;
            }

            // Print updated health
            print(health);
        }

        // Print final message
        print("Player has been unalived!");
    }
}