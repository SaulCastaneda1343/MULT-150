using UnityEngine;

public class CubeScript : MonoBehaviour
{
    void Update()
    {
        // Move the cube along the X axis
        transform.Translate(0.05f, 0f, 0f);

        // Rotate the cube around the Y axis
        transform.Rotate(0f, 0f, 1f);

        // Scale the cube uniformly
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
