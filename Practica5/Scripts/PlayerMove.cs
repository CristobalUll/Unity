using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
