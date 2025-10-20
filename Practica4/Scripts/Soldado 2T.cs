using UnityEngine;

public class Soldado2T : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform shield;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        Captain.OnMensajeEnviado += EscucharMensaje;
    }

    void OnDisable()
    {
        Captain.OnMensajeEnviado -= EscucharMensaje;
    }
    
    void EscucharMensaje(string mensaje)
    {
        if (mensaje == "cubo_cerca")
        {
            Vector3 direction = shield.position - rb.position;
            direction.y = 0;
            rb.rotation = Quaternion.LookRotation(direction);
            Debug.Log($"{name} mirando hacia escudo {shield.name}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
