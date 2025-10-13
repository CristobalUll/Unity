using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("He chocado (" + rb.name + ") contra: " + collision.gameObject.name);
        rb.gameObject.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
