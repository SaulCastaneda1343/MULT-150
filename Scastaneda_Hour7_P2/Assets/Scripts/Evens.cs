using UnityEngine;

public class Evens : MonoBehaviour
{
    void Start()
    {
        // Solution 1: Using a for loop with step modification
        for (int i = 22; i <= 100; i += 2)
        {
            Debug.Log(i);
        }

        // Alternative Solution: Using a for loop with an if statement
        /*
        for (int i = 22; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
        */
    }
}
