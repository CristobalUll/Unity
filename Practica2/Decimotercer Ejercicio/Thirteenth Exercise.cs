using UnityEngine;

public class ThirteenthExercise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private GameObject cube;
    private float speed = 5f;
    private float rotation = 100f;

    void Start()
    {
        cube = GameObject.FindWithTag("FirstCube");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        cube.transform.Rotate(0, horizontal * rotation * Time.deltaTime, 0);

        cube.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);

        Debug.DrawRay(cube.transform.position, cube.transform.forward * 2, Color.red);
    }
}
