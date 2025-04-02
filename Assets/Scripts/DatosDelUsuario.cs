using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    public int edadUsuario;
    public float estaturaUsuario;
    public bool esDonante;


    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario);
        Debug.Log("Tengo " + edadUsuario + " años");
        Debug.Log("Mido " + estaturaUsuario + " metros");
        Debug.Log("Es " + esDonante + " que soy donante de órganos");
    }
}



