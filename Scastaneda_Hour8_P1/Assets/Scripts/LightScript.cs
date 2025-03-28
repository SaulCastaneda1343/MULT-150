using UnityEngine;

public class LightScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }
    }
}
