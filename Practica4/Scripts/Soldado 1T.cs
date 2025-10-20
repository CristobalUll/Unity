using UnityEngine;

public class Soldado1T : MonoBehaviour
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
            Vector3 vector = new Vector3(shield.position.x, 0, shield.position.z);
            rb.position = vector;
            Debug.Log($"{name} teletransportado a escudo {shield.name}");
        }
    }

  // Update is called once per frame
  void Update()
    {
        
    }
}
