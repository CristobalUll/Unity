using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int count = 0;
    private Renderer sphereRenderer;

    void Start()
    {
        sphereRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 120)
        {
            Color random = new Color(Random.value, Random.value, Random.value);
            sphereRenderer.material.color = random;
            count = 0;
        }
        else
        {
            count++;
        }
    }
}
