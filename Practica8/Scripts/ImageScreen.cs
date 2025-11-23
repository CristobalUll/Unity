using UnityEngine;

public class ImageScreeen : MonoBehaviour
{
    private Material tvMaterial;
    private WebCamTexture webcamTexture;
    private int captureCounter = 1;

    void Start()
    {
        // Obtener material del objeto
        Renderer renderer = GetComponent<Renderer>();
        tvMaterial = renderer.material;

        // Mostrar cámaras disponibles
        if (WebCamTexture.devices.Length == 0)
        {
            Debug.LogWarning("No hay cámaras disponibles.");
            return;
        }

        Debug.Log(" CÁMARAS DISPONIBLES ");
        foreach (var cam in WebCamTexture.devices)
            Debug.Log("- " + cam.name);

        // Usar la primera cámara
        webcamTexture = new WebCamTexture(WebCamTexture.devices[0].name);

        Debug.Log("Usando la cámara: " + webcamTexture.deviceName);
    }

    void Update()
    {
        // INICIAR cámara — S
        if (Input.GetKeyDown(KeyCode.S))
        {
            tvMaterial.mainTexture = webcamTexture;
            webcamTexture.Play();
            Debug.Log("Cámara iniciada.");
        }

        // PAUSAR cámara — P
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (webcamTexture.isPlaying)
            {
                webcamTexture.Pause();
                Debug.Log("Cámara pausada.");
            }
        }

        // CAPTURAR fotograma — X
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (webcamTexture.isPlaying)
            {
                Texture2D photo = new Texture2D(webcamTexture.width, webcamTexture.height);
                photo.SetPixels(webcamTexture.GetPixels());
                photo.Apply();

                string folder = Application.dataPath + "/Capturas/";
                System.IO.Directory.CreateDirectory(folder);

                string file = folder + "captura_" + captureCounter + ".png";
                System.IO.File.WriteAllBytes(file, photo.EncodeToPNG());

                Debug.Log("Fotograma guardado en: " + file);

                captureCounter++;
            }
        }
    }
}