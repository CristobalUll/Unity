using UnityEngine;

public class FourthExercise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private GameObject cube;
    private GameObject cylinder;
    private GameObject sphere;

    void Start()
    {
        cube = GameObject.FindWithTag("FirstCube");
        cylinder = GameObject.FindWithTag("FirstCylinder");
        sphere = GameObject.FindWithTag("FirstSphere");

        Debug.Log("Distancia de la esfera al cubo: " + Vector3.Distance(sphere.transform.position, cube.transform.position));
        Debug.Log("Distancia de la esfera al cilindro: " + Vector3.Distance(sphere.transform.position, cylinder.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
