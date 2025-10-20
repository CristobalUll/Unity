using System;
using UnityEngine;

public class Esfera1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    
    public Transform objetivo;
    public float velocidad = 0.1f;
    public bool mover = false;

    void OnEnable()
    {
        Mensajero.OnColisionCilindro += EmpezarMovimiento;
    }

    void OnDisable()
    {
        Mensajero.OnColisionCilindro -= EmpezarMovimiento;
    }

    void EmpezarMovimiento()
    {
        mover = true;
    }  

    // Update is called once per frame
    void Update()
    {
        if (mover)
        {
            Vector3 direccion = (objetivo.position - transform.position).normalized;
            transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
        }
    }
}
