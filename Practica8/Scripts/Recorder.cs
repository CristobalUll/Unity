using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour
{
    private AudioSource audioSource;
    private string micName;
    private AudioClip recordedClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (Microphone.devices.Length == 0)
        {
            Debug.LogWarning("No hay micrófonos disponibles.");
            return;
        }

        micName = Microphone.devices[0];
        Debug.Log("Usando micrófono: " + micName);

        recordedClip = Microphone.Start(micName, true, 10, 44100);
        audioSource.clip = recordedClip;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!Microphone.IsRecording(micName))
            {
                audioSource.Play();
                Debug.Log("Reproduciendo audio grabado...");
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (Microphone.IsRecording(micName))
            {
                Microphone.End(micName);
                Debug.Log("Grabación detenida.");
            }
        }
    }
}