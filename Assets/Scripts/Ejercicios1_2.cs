using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios1_2 : MonoBehaviour
{
    string saludo = " Hola Mundo!";
    string despedida = "Estoy aprendiendo aún, seguiremos informando";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(saludo + " Este es el primer videojuego del Sr.Lescura");
        Debug.Log(despedida);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame");
        //Es porque cada frame esta funcion se actualiza
    }
}
