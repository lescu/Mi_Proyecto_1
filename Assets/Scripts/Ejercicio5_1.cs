using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField]int vidaEnemigo1;
    [SerializeField]int vidaEnemigo2;
    // Start is called before the first frame update
    void Start()
    {
        if (vidaEnemigo1 == vidaEnemigo2)
        {
            Debug.Log("Ambos jugadores tienen la misma vida");
        }
        else if (vidaEnemigo1 > vidaEnemigo2)
        {
            Debug.Log("El jugador 1 tiene mas vida");
        }
        else
        {
            Debug.Log("El jugdor 2 tiene mas vida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
