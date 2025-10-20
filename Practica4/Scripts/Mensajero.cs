using System;
using UnityEngine;

public class Mensajero
{
    public static Action OnColisionCilindro;

    public static void EnviarMensaje(string mensaje)
    {
        Debug.Log("Mensaje enviado");
        OnColisionCilindro?.Invoke();
    }
}
