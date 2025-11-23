using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed = 5f; // velocidad configurable
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Movimiento básico con WASD o flechas
        float x = Input.GetAxisRaw("Horizontal");   // A/D o ←/→
        float z = Input.GetAxisRaw("Vertical");     // W/S o ↑/↓

        Vector3 movement = new Vector3(x, 0f, z).normalized;

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}