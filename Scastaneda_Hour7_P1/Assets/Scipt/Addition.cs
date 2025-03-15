using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Declare and assign values to the variables
        int a = 2;
        int b = 4;
        int c = 8;
        int sum;

        // Add a, b, and c, and assign the result to sum
        sum = a + b + c;

        // Increment sum by 1
        sum++;

        // Print the value of sum to the console
        print(sum);
    }

    // Update is called once per frame
    void Update()
    {
        print("This is called once a frame");
    }
}