using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeV2 : MonoBehaviour
{
    private string mario;
    private int vida;
    private float experiencia;
    private float LVL;

    public float LVL1 { get => LVL; set => LVL = value; }

    // Start is called before the first frame update
    void Start()
    {

    }

    float CalcularNivel(float experiencia, float LVL)
    {
        LVL = experiencia / 100;
        return LVL;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
