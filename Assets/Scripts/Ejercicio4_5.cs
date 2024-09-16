using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        float resultadoTriangulo = CalculoTriangulo(5.25f, 10.5f);
        string resultado = Convertir(resultadoTriangulo);
        Debug.Log(resultado);
    }
    float CalculoTriangulo(float baseTriangulo, float alturaTriangulo)
    {
        float operacionTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        return operacionTriangulo;
    }
     float CalculoCirc(float Pi, float radioCirc)
    {
        float CalculoACirc= (radioCirc * radioCirc) * Pi;
        return CalculoACirc;

    }
    string Convertir(float CalculoTriangulo)
    {
        string OperarConversion = CalculoTriangulo * 1.11f + " Dollar en el triangulo";
        return OperarConversion;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
