using UnityEngine;

public class SecondExercise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 firstVector;
    public Vector3 secondVector;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

#if UNITY_EDITOR
    void OnValidate()
    {
        Debug.Log("Primer Vector: Magnitud: " + firstVector.magnitude + " | Ángulo: " + Vector3.Angle(firstVector, secondVector) + " | Distancia: " + Vector3.Distance(firstVector, secondVector));
        Debug.Log("Segundo Vector: Magnitud: " + secondVector.magnitude + " | Ángulo: " + Vector3.Angle(firstVector, secondVector) + " | Distancia: " + Vector3.Distance(firstVector, secondVector));

        if (firstVector.y > secondVector.y)
        {
            Debug.Log("El primer vector está más arriba");
        }
        else if (firstVector.y < secondVector.y)
        {
            Debug.Log("El segundo vector está más arriba");
        }
        else
        {
            Debug.Log("Los dos vectores están a la misma altura");
        }
    }
    #endif

}
