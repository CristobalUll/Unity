using System.Collections;
using UnityEngine;

public class WarriorSimpleController : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSmooth = 5f;

    // Zona permitida
    public float minLat = 23.38750f;
    public float maxLat = 30.38850f;
    public float minLon = -14.52300f;
    public float maxLon = -17.52150f;

    private bool gpsReady = false;

    IEnumerator Start()
    {
        Input.compass.enabled = true;

        // GPS
        if (!Input.location.isEnabledByUser)
            yield break;

        Input.location.Start();
        int wait = 20;

        while (Input.location.status == LocationServiceStatus.Initializing && wait > 0)
        {
            wait--;
            yield return new WaitForSeconds(1);
        }

        if (Input.location.status == LocationServiceStatus.Running)
            gpsReady = true;
    }

    void Update()
    {
        RotateToNorth();
        MoveByTilt();
    }

    void RotateToNorth()
    {
        float heading = Input.compass.trueHeading;
        Quaternion target = Quaternion.Euler(0, -heading, 0);

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            target,
            rotationSmooth * Time.deltaTime
        );
    }

    void MoveByTilt()
    {
        if (!gpsReady) return;
        if (!InsideArea()) return;

        Vector3 a = Input.acceleration;

        // Detectar automáticamente cuál eje del móvil corresponde a la inclinación adelante/atrás
        float forward;
        if (Mathf.Abs(a.z) > Mathf.Abs(a.y))
            forward = -a.z;
        else
            forward = -a.y;

        transform.position += transform.forward * forward * speed * Time.deltaTime;
    }

    bool InsideArea()
    {
        var d = Input.location.lastData;
        return (d.latitude >= minLat && d.latitude <= maxLat &&
                d.longitude >= minLon && d.longitude <= maxLon);
    }
}