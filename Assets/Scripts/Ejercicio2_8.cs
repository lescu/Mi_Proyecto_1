using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vida = 120f;
    float PorcntgVida;
    // Start is called before the first frame update
    void Start()
    {
        PorcntgVida = (vida * 3) / 100;
        
        vida -= PorcntgVida;
        Debug.Log(vida); //3%

        vida -= PorcntgVida * 2;
        Debug.Log(vida); //6%

        vida -= PorcntgVida * 3;
        Debug.Log(vida);

        vida -= PorcntgVida * 4;
        Debug.Log(vida);

        vida -= PorcntgVida * 5;
        Debug.Log(vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
