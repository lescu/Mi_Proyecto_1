using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numero1;
    int numero2 = -10;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 > numero2)
        {
            for (int i = numero1; i < numero2; i--)
            {
                Debug.Log(i);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
