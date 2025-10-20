using UnityEditor.Callbacks;
using UnityEngine;

public class Referencia : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform referencia;
    public float speed = 7f;
    public float activacion = 2f;
    private bool mensajeEnviado = false;
    private Rigidbody rb;
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

        float distance = Vector3.Distance(rb.position, referencia.position);

        if (distance < activacion && !mensajeEnviado)
        {
            Captain.EnviarMensaje("cubo_cerca");
            mensajeEnviado = true;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + vector * speed * Time.fixedDeltaTime);
    }
}
