using UnityEngine;

public class ThirdExercise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    GameObject sphere;
    void Start()
    {
        sphere = GameObject.FindWithTag("FirstSphere");

        Debug.Log("Posición de la esfera: " + sphere.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
