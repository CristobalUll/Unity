
using UnityEngine;

public class CuboControlador : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;
    public float speed = 7f;
    private Vector3 vector;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        vector = new Vector3(horizontal, 0f, vertical).normalized;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + vector * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Type 1"))
        {
            Captain.EnviarMensaje("Tipo 1");
        } else if (collision.gameObject.CompareTag("Type 2"))
        {
            Captain.EnviarMensaje("Tipo 2");
        }
    }
}
