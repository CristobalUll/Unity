using UnityEngine;

public class FifthExerciseSphere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 desplazamiento;
    [HideInInspector] public Vector3 posicionOriginal;

    void Start()
    {
        posicionOriginal = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
