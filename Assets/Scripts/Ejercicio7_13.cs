using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField]int numero;
    // Start is called before the first frame update
    void Start()
    {
        string comprobacion = NumeroPrimo(numero) ;
        Debug.Log(comprobacion);
    }
    string NumeroPrimo( int numero )
    {
        if ( numero % 2 != 0 && numero % 3 != 0 && numero % 4 != 0 && numero % 5 != 0 && (numero % 7 != 0 || numero % 7 == 0) )
        {
            string verdadero = "Es numero Primo";
            return verdadero;
        }
        else
        {
            string falso = "No es numero primo";
            return falso;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
