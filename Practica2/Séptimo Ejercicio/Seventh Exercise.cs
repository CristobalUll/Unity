using UnityEngine;

public class Seventh : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Disparo"))
        {
            // Aquí va la función de disparo
            Debug.Log("¡Disparo activado con H!");
        }
    }
}
