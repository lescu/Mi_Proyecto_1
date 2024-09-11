using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vida = 10;
    float exp = 3f;
    char Carac = '4';
    float resultadoSuma;
    float resultadoResta;
    
    // Start is called before the first frame update
    void Start()
    {
        resultadoSuma = vida + exp;
        Debug.Log(resultadoSuma);

        resultadoResta = vida - exp;
        Debug.Log(resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
