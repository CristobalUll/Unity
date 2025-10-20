using UnityEngine;
using UnityEngine.UI;

public class Recolector3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;
    private int puntuacion = 10;
    public Text puntuacionTexto;
    private Vector3 vector;
    public Transform enemigo;
    public float rangoActivacion = 10f;
    
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

        float distancia = Vector3.Distance(transform.position, enemigo.position);

        if (distancia < rangoActivacion)
        {
            Captain.EnviarMensaje("cubo_cerca");
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + vector * 7f * Time.fixedDeltaTime);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            puntuacion += 5;
            Destroy(collision.gameObject);
            Debug.Log($"Puntuación: {puntuacion}");
            ActualizarTexto();

        }
        else if (collision.gameObject.CompareTag("Collectible2"))
        {
            puntuacion += 10;
            Destroy(collision.gameObject);
            Debug.Log($"Puntuación: {puntuacion}");
            ActualizarTexto();

        }
        else if (collision.gameObject.CompareTag("Type 2"))
        {
            puntuacion -= 5;
            Debug.Log($"Puntuación: {puntuacion}");
            ActualizarTexto();
        }
    }
    
    void ActualizarTexto()
    {
        puntuacionTexto.text = "Puntuación: " + puntuacion.ToString();
    }
}
