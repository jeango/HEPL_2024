using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public Renderer renderer;
    public float speed;
    
    private Material material;
    // Start is called before the first frame update
    void Start()
    {
        material = renderer?.material;
    }

    // Update is called once per frame
    void Update()
    {
        if (material != null)
        {
            material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
        }
    }
}
