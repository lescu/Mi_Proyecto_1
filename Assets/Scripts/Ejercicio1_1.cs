using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    //Declarar variables
    
    int vida; //Por defecto es 0.
    float porcentajeAciertos; //Por defecto es un 0.0f
    bool quemado; //Por defecto es false.
    string explorador; //Por defecto es ""
    char solucionPuzzle; //Por defecto es ''

    //[SerializeField] -> mostrar en el inspector, no hace falta poner unidades
    [SerializeField] int mostrar;

    //Variables globales
    float variablesGlobales;

    int pocion = 9;
    int OpcionA = 3;
    int OpcionB = 6;
    int OpcionC;

    //Condicionales 
    [SerializeField]bool CarnetConducir;
    int edad = 18;

    // Start is called before the first frame update
    void Start()
    {
        vida = 9; //Asignar valor a variable.

        //Sumas y Restas

        // Vida = vida + 3 -> Es lo mismo
        vida += 3;
        vida -= 4;
        vida += pocion;

        //Equivalen a sumar o restar uno
        vida++;
        vida--;


        //Multiplicacion y division

        vida *= 2;
        vida /= 2;


        //OpcionA = OpcionB             Esto es lo mismo 
        //OpcionC = OpcionA             

        OpcionA = 6;
        OpcionC = 6;

        if (CarnetConducir == true)
        {
            Debug.Log("Puedes Conducir");
        }

        Debug.Log("Hola Mundo!");


        //Anidamiento: Meter estructura dentro de otra 
        
        if (edad >= 18) //Filtro 1 -> Si tienes edad suficiente
        {
            if (CarnetConducir == true) //Filtro 2 -> 
            {
                Debug.Log("Puedo conducir legalmente");
            }
        }
    }

    void SumarNumeros()
    {
        //variablesGlobales();
        //Debug.Log(varialesGlobales);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
