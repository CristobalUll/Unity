#if UNITY_EDITOR
using UnityEngine;

public class MouseLookSimulator : MonoBehaviour
{
    public float sensitivity = 2f;
    float rotX, rotY;

    void Update()
    {
        rotX += Input.GetAxis("Mouse X") * sensitivity;
        rotY -= Input.GetAxis("Mouse Y") * sensitivity;
        rotY = Mathf.Clamp(rotY, -80, 80);
        transform.localRotation = Quaternion.Euler(rotY, rotX, 0);
    }
}
#endif
