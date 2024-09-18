using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    string nombre;
    string apellido1;
    string apellido2;
    int edad;
    string presentacion;

    // Start is called before the first frame update
    void Start()
    {
        string presentacion = ConstrucPresentacion("Nico", "Martin", "Mora", 25);
        Debug.Log(presentacion);
        
    }
    string ConstrucPresentacion(string nombre, string apellido1, string apellido2, int edad)
    {
        string ComposicionPresentacion = "Hola me llamo " + nombre + apellido1 + apellido2 + " y tengo " + edad + "años.";
        return ComposicionPresentacion;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
