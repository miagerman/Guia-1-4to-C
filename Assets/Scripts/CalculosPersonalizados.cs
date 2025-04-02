using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{
    public float num1;
    public float num2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El resultado de la suma entre " + num1 + " y " + num2 + " es: " + (num1 + num2));
        Debug.Log("El resultado de la resta entre " + num1 + " y " + num2 + " es: " + (num1 - num2));
        Debug.Log("El resultado de la multiplicación entre " + num1 + " y " + num2 + " es: " + (num1 * num2));
        Debug.Log("El resultado de la división entre " + num1 + " y " + num2 + " es: " + (num1 / num2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
