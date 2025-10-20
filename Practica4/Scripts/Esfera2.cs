using UnityEngine;

public class Esfera2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public Transform cilindro;
    public float velocidad = 5f;
    public bool mover = false;

    public void OnEnable()
    {
        Mensajero.OnColisionCilindro += EmpezarMovimiento;
    }

    public void OnDisable()
    {
        Mensajero.OnColisionCilindro -= EmpezarMovimiento;
    }

    public void EmpezarMovimiento()
    {
        mover = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (mover)
        {
            Vector3 direccion = (cilindro.position - transform.position).normalized;
            transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
        }
    }
}
