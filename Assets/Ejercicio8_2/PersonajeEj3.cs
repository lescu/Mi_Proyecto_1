using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeEj3 : MonoBehaviour
{
    [SerializeField] int vidaInicial;
    float vidaActual;
    float cantidadVida = 25;
    float cantidadDanho = 23;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float RecibirCura(float vidaInicial , float cantidadVida , float vidaActual)
    {
        vidaActual = vidaActual + cantidadVida;
        return vidaActual;
    }
    public float RecibirDanho(float vidaInicial , float cantidadDanho, float vidaActual)
    {
        vidaActual = vidaActual - cantidadDanho;
        return vidaActual;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
