using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    int numero1 = 10;
    int numero2 = 32;
    // Start is called before the first frame update
    void Start()
    {
        for (int numero1 = numero2; numero2 > numero1; numero1++)
        {
            Debug.Log(numero1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
