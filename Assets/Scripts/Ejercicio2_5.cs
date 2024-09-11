using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 3;
    int vidasPlayer2 = 6;
    int vidasPlayer3 = 9;   
    int vidasPlayer4 = 21;
    int vidasPlayer2_1= 6;
    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2 = vidasPlayer3;
        Debug.Log("Player 2 -> " + vidasPlayer2 + " vidas");

        vidasPlayer3 = vidasPlayer1;
        Debug.Log("Player 3 -> " + vidasPlayer3 + " vidas");

        vidasPlayer1 = vidasPlayer4;
        Debug.Log("Player 1 -> " + vidasPlayer1 + " vidas");

        vidasPlayer4 = vidasPlayer2_1;
        Debug.Log("Player 4 -> " + vidasPlayer4 + "vidas");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
