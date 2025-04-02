 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeclaracionDeVariables : MonoBehaviour
{
    int cantidadAlumnos = 30;
    float kilosVendidos = 12.5f;
    string nombreAlumno = "Mateo";
    bool estaAprobado = true;


    void Start()
    {
        Debug.Log("Cantidad de Alumnos: " + cantidadAlumnos);
        Debug.Log("Kilos Vendidos: " + kilosVendidos);
        Debug.Log("Nombre Alumno: " + nombreAlumno);
        Debug.Log("Esta aprobado: " + estaAprobado);
    }
}



