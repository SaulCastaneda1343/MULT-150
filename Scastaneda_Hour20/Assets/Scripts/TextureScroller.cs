using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = 0.5f;

    private Renderer renderer;
    private float offset;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Increase offset based on time
        offset += Time.deltaTime * speed;

        // Keep offset between 0 and 1
        if (offset > 1)
            offset -= 1;

        // Apply the offset to the material
        renderer.material.mainTextureOffset = new Vector2(0, offset);
    }
}
