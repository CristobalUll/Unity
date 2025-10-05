using UnityEngine;

public class TwelfthExercise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5f;
    public GameObject sphere;
    public GameObject cube;

    void Start()
    {
        sphere = GameObject.FindWithTag("FirstSphere");
        cube = GameObject.FindWithTag("FirstCube");
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.LookAt(sphere.transform, Vector3.up);

        float horizontal = 0f;
        float vertical = 0f;

        if (Input.GetKey(KeyCode.A)) horizontal = -1f;
        if (Input.GetKey(KeyCode.D)) horizontal = 1f;
        if (Input.GetKey(KeyCode.W)) vertical = 1f;
        if (Input.GetKey(KeyCode.S)) vertical = -1f;

        sphere.transform.Translate(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime, Space.World);
    }
}