using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PersonajeV2 personaje1;
    [SerializeField] PersonajeV2 personaje2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void PrepararPersonaje()
    {
        personaje1.Nombre = "Mario";
        personaje1.Vida = 100;
        personaje1.Experiencia = 59f;
        //personaje1.LVL1;
        
        Debug.Log("Nivel de " +  personaje1.Nombre + " -> " + personaje1.LVL1);

    }
    float Operacion(float Experiencia)
    {
        personaje1.LVL1 = personaje1.Experiencia / 1000;
        return personaje1.LVL1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
