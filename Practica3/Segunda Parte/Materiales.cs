using UnityEngine;

public class Materiales : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float fuerza = 500f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Lanzable"))
            {
                Rigidbody rb = obj.GetComponent<Rigidbody>();
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                rb.AddForce(Vector3.forward * fuerza);
            }
        }
    }
}
