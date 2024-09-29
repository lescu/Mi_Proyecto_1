using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeV2 : MonoBehaviour
{
    private string nombre;
    private int vida;
    private float experiencia;
    private float LVL;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public float LVL1 { get => LVL; set => LVL = value; }


    // Start is called before the first frame update
    void Start()
    {

    }
    float CalculoNVL(float experiencia)
    {
        LVL = experiencia / 1000;
        return LVL;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
