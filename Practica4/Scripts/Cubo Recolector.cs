using UnityEngine;

public class CuboRecolector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;
    private int puntuacion = 0;
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
        rb.MovePosition(rb.position + vector * 7f * Time.fixedDeltaTime);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            puntuacion += 5;
            Destroy(collision.gameObject);
            Debug.Log($"Puntuación: {puntuacion}");

        } else if (collision.gameObject.CompareTag("Collectible2"))
        {
            puntuacion += 10;
            Destroy(collision.gameObject);
            Debug.Log($"Puntuación: {puntuacion}");
        }
    }
}
