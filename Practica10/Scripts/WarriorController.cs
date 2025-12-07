using UnityEngine;

public class WarriorController : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 90f;

    public void EjecutarOrden(string orden)
    {
        orden = orden.ToLower();

        if (orden.Contains("avanza") || orden.Contains("adelante"))
            Avanzar();
        else if (orden.Contains("gira") || orden.Contains("rota"))
            Girar();
        else if (orden.Contains("ataca"))
            Atacar();
        else if (orden.Contains("defiende") || orden.Contains("escudo"))
            Defender();
        else
            Debug.Log("Orden no reconocida: " + orden);
    }

    void Avanzar()
    {
        Debug.Log(name + ": Avanzando");
        transform.Translate(Vector3.forward * speed, Space.Self);
    }

    void Girar()
    {
        Debug.Log(name + ": Girando");
        transform.Rotate(Vector3.up * rotationSpeed);
    }

    void Atacar()
    {
        Debug.Log(name + ": ¡Atacando!");
    }

    void Defender()
    {
        Debug.Log(name + ": Defendiéndose con escudo");
    }
}