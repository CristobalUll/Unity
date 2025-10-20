using UnityEngine;
using UnityEngine.UI;

public class Recolector2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;
    private int puntuacion = 0;
    private Vector3 vector;
    public Text recompensaTexto = null;
    public Text puntuacionTexto;
    private int recompensa = 100;

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
            VerificarRecompensa();

        }
        else if (collision.gameObject.CompareTag("Collectible2"))
        {
            puntuacion += 10;
            Destroy(collision.gameObject);
            Debug.Log($"Puntuación: {puntuacion}");
            ActualizarTexto();
            VerificarRecompensa();
        }
    }

    void ActualizarTexto()
    {
        puntuacionTexto.text = "Puntuación: " + puntuacion.ToString();
    }
    
    void VerificarRecompensa()
    {
        if (puntuacion >= recompensa)
        {
            recompensaTexto.text += "WINNER!";
            Debug.Log("Recompensa obtenida en " + puntuacion + " puntos!");

            recompensa += 100;

            CancelInvoke(nameof(LimpiarRecompensa));
            Invoke(nameof(LimpiarRecompensa), 3f);
        }
    }

    void LimpiarRecompensa()
    {
        recompensaTexto.text = "";
    }
}
