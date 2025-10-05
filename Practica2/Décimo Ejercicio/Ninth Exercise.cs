using UnityEngine;

public class Ninth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5f;
    public GameObject cube;
    public GameObject sphere;

    void Start()
    {
        cube = GameObject.FindWithTag("FirstCube");
        sphere = GameObject.FindWithTag("FirstSphere");
    }

    // Update is called once per frame
    void Update()
    {
        if (cube != null)
        {

            float horizontal = 0f;
            float vertical = 0f;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                horizontal = -1f;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                horizontal = 1f;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                vertical = 1f;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                vertical = -1f;
            }

            cube.transform.Translate(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);

        }

        if (sphere != null)
            {
                float horizontal = 0f;
                float vertical = 0f;

                if (Input.GetKey(KeyCode.A))
                {
                    horizontal = -1f;
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    horizontal = 1f;
                }
                else if (Input.GetKey(KeyCode.W))
                {
                    vertical = 1f;
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    vertical = -1f;
                }

                sphere.transform.Translate(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);
            }
    }
}
