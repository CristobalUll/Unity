using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;
    public float speed = 3f;
    private bool perseguir = false;

    void Start()
  {
    
  }

    void OnEnable()
    {
        Captain.OnMensajeEnviado += EscucharMensaje;
    }

    void OnDisable()
    {
        Captain.OnMensajeEnviado -= EscucharMensaje;
    }

    void Update()
    {
        if (perseguir)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            direction.y = 0;
            transform.Translate(new Vector3(direction.x, 0, direction.z) * speed * Time.deltaTime, Space.World);
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 5f * Time.deltaTime);
        }   
    }
    
    void EscucharMensaje(string mensaje)
    {
        if (mensaje == "cubo_cerca")
        {
            perseguir = true;
        }
    }
}
