using UnityEngine;

public class fireballscript : MonoBehaviour
{
    void Start()
    {
        int x = TakeDamageFromFireball();
        print("Player health: " + x);

        int y = TakeDamageFromFireball(25);
        print("Player health: " + y);

        int z = TakeDamageFromFireball(30, 50);
        print("Player health: " + z);
    }

    void Update()
    {
        // Optional: logic for repeated updates
    }

    // Method 1: No parameters
    int TakeDamageFromFireball()
    {
        int playerHealth = 100;
        return playerHealth - 5;
    }

    // Method 2: One parameter
    int TakeDamageFromFireball(int damage)
    {
        int playerHealth = 100;
        return playerHealth - damage;
    }

    // Method 3: Two parameters
    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }
}
