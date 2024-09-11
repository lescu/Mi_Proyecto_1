using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vida = 15;
    float exp = 7.5f;

    float producto;
    float cociente;
    int dobleVidas;
    float tripleExp;
    // Start is called before the first frame update
    void Start()
    {
        producto = vida * exp;
        cociente = vida / exp;
        dobleVidas = vida * 2;
        tripleExp = exp * 3;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
