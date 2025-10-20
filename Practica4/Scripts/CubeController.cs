using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cylinder"))
        {
            Debug.Log("El cubo ha colisionado con el cilindro.");
            Mensajero.EnviarMensaje("ColisionCuboCilindro");
        }
    }
}
