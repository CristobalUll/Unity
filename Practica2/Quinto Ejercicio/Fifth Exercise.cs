using UnityEngine;

public class FifthExercise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private FifthExerciseSphere cube;
    private FifthExerciseSphere sphere;
    private FifthExerciseSphere cylinder;

    void Start()
    {
        cube = GameObject.FindWithTag("FirstCube").GetComponent<FifthExerciseSphere>();
        sphere = GameObject.FindWithTag("FirstSphere").GetComponent<FifthExerciseSphere>();
        cylinder = GameObject.FindWithTag("FirstCylinder").GetComponent<FifthExerciseSphere>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            cube.transform.position = cube.posicionOriginal + cube.desplazamiento;
            sphere.transform.position = sphere.posicionOriginal + sphere.desplazamiento;
            cylinder.transform.position = cylinder.posicionOriginal + cylinder.desplazamiento;
        }
    }
}
