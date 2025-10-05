using UnityEngine;

public class EleventhExercise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private GameObject cube;
    private GameObject sphere;
    private float speed = 3f;

    void Start()
    {
        cube = GameObject.FindWithTag("FirstCube");
        sphere = GameObject.FindWithTag("FirstSphere");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vcube = cube.transform.position;
        Vector3 vsphere = sphere.transform.position;

        Vector3 direction = vsphere - vcube;

        direction = direction.normalized;

        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}

