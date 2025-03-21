using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    void Start()
    {
        // Declare float variables and assign values
        float health = 1004f;
        float poisonDamage = 125.5f;

        // Loop runs while health is greater than 0
        while (health > 0)
        {
            // Print the current health value
            Debug.Log(health);

            // Subtract poisonDamage from health
            health -= poisonDamage;

            // Ensure health does not go below 0
            if (health < 0)
            {
                health = 0;
            }
        }

        // Print final health value (0)
        Debug.Log(health);

        // Check if the player is unalived
        if (health <= 0)
        {
            Debug.Log("Player has been unalived!");
        }
    }
}
