using Unity.VisualScripting;
using UnityEngine;

public class EighthExercise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 2f;
    public bool localSpace = false;

    void Start()
    {
        Vector3 pos = transform.position;
        pos.y = 0;
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        float dx = moveDirection.x * speed * Time.deltaTime;
        float dy = moveDirection.y * speed * Time.deltaTime;
        float dz = moveDirection.z * speed * Time.deltaTime;

        if (localSpace) {
            transform.Translate(dx, dy, dz, Space.Self);
        } else {
            transform.Translate(dx, dy, dz, Space.World);
        }
    }
}
