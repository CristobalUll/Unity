using UnityEngine;

public class Soldado2 : MonoBehaviour
{
    public Transform shield;
    public float speed = 5f;
    private bool move = false;

    void Start()
    {

    }

    private void OnEnable()
    {
        Captain.OnMensajeEnviado += EscucharMensaje;
    }

    private void OnDisable()
    {
        Captain.OnMensajeEnviado -= EscucharMensaje;
    }

    void EscucharMensaje(string mensaje)
    {
        if (mensaje == "Tipo 1")
        {
            move = true;
        }
    }

    void Update()
    {
        if (move)
        {
            Vector3 direction = (shield.position - transform.position).normalized;
            transform.Translate(new Vector3(direction.x, 0, direction.z) * speed * Time.deltaTime, Space.World);
        }
    }
}
