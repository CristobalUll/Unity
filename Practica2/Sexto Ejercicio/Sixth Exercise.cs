using UnityEngine;

public class SixthExercise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidad = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Flecha Arriba: " + (velocidad * ejeVertical));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Flecha Abajo: " + (velocidad * ejeVertical));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Flecha Izquierda: " + (velocidad * ejeHorizontal));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Flecha Derecha: " + (velocidad * ejeHorizontal));
        }
    }
}
