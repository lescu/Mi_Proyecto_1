using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    string jugador1 = "jugador1";
    string jugador2 = "jugador2";
    string jugador3 = "jugador3";

    [SerializeField] float velocidad1;
    [SerializeField] float velocidad2;
    [SerializeField] float velocidad3;
    // Start is called before the first frame update
    void Start()
    {
        if (velocidad1 > velocidad2)
        {
            if (velocidad1 > velocidad3)
            {
                Debug.Log(jugador1 + " atacará primero");
            }
            else
            {
                Debug.Log(jugador1 + " atacará segundo");
            }
        }
        else if (velocidad1 > velocidad3)
        {
            Debug.Log(jugador1 + " atacará segundo");
        }
        else
        {
            Debug.Log(jugador1 + " atacará tercero");
        }

        if (velocidad2 > velocidad1)
        {
            if (velocidad2 > velocidad3)
            {
                Debug.Log(jugador2 + " atacará primero");
            }
        }
        else if (velocidad2 > velocidad3)
        {
            Debug.Log(jugador2 + " atacará segundo");
        }
        else
        {
            Debug.Log(jugador2 + " atacará tercero");
        }
       
        if (velocidad3 > velocidad2)
        {
            if (velocidad3 > velocidad1)
            {
                Debug.Log(jugador3 + " atacará primero");
            }
            else
            {
                Debug.Log(jugador3 + " atacará segundo");
            }
        }
        else if (velocidad3 > velocidad1)
        {
            Debug.Log(jugador3 + " atacará segundo");
        }
        else
        {
            Debug.Log(jugador3 + " atacará tercero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
