using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int cantidadAlumnos;
    float kilosVendidos;
    string nombreAlumno;
    bool estaAprobado;

    // Start is called before the first frame update
    void Start()
    {
        
        cantidadAlumnos = 30;
        kilosVendidos = 12.5f;
        nombreAlumno = "Mateo";
        estaAprobado = false;
        Debug.Log(cantidadAlumnos);
        Debug.Log(kilosVendidos);
        Debug.Log(nombreAlumno);
        Debug.Log(estaAprobado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
