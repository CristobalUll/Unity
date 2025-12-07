using UnityEngine;
using Whisper;

public class VoiceController : MonoBehaviour
{
    public WhisperManager whisper;
    public int sampleRate = 16000;

    private AudioClip recording;
    private bool recordingActive = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            StartRecording();

        if (Input.GetKeyUp(KeyCode.R))
            StopRecording();
    }

    void StartRecording()
    {
        if (recordingActive) return;

        Debug.Log("Grabando voz...");
        recording = Microphone.Start(null, false, 5, sampleRate);
        recordingActive = true;
    }

    async void StopRecording()
    {
        if (!recordingActive) return;

        Debug.Log("Fin grabación");
        Microphone.End(null);
        recordingActive = false;

        // Convertir audio en float[]
        float[] samples = new float[recording.samples];
        recording.GetData(samples, 0);

        Debug.Log("Transcribiendo voz...");
        var result = await whisper.GetTextAsync(samples, sampleRate, 1);

        string texto = result.Result;
        Debug.Log("Transcripción: " + texto);

        if (SeleccionGuerrero.guerreroSeleccionado != null)
            SeleccionGuerrero.guerreroSeleccionado.EjecutarOrden(texto);
        else
            Debug.Log("No hay guerrero seleccionado. Haz clic en uno primero.");
    }
}