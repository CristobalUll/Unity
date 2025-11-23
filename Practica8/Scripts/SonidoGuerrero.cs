using UnityEngine;

public class SonidoGuerrero : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
            Debug.Log("¡Sonido reproducido! Guerrero alcanzó el objetivo.");
        }
    }
}