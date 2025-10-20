using System;
using UnityEngine;

public class Captain
{
    public static event Action<string> OnMensajeEnviado;

    public static void EnviarMensaje(string mensaje)
    {
        Debug.Log("Mensaje enviado desde Captain");
        OnMensajeEnviado?.Invoke(mensaje);
    }
}
