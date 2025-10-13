using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5f;
    private Rigidbody rb;
    private Vector3 vector;
    private Light light;
    private bool zone;
    private float intensidad;
    private Color color;
    public int damage = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        light = GameObject.FindFirstObjectByType<Light>();

        intensidad = light.intensity;
        color = light.color;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        vector = new Vector3(horizontal, 0f, vertical).normalized;

        if (zone == true)
        {
            light.intensity -= speed * Time.deltaTime;
            light.color = Color.Lerp(Color.white, Color.blue * 0.3f, 1 - light.intensity);
        } else
        {
            light.intensity = intensidad;
            light.color = color;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + vector * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube")
        {
            zone = true;
        }
        else if (other.name == "Sphere")
        {
            damage += 5;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Cube")
        {
            zone = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane")
        {
            Debug.Log("Enemigo encontrado");
        }
    }
}
