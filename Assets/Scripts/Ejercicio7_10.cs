using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero2 < numero1)
        {
            for (int i = numero2; i <= numero1; i++)
            {
                if (i >= 0)
                {
                    if (i % 2 == 0)
                    {
                        Debug.Log(i + " Es positivo y par");
                    }
                    else
                    {
                        Debug.Log(i + " Es positivo e impar");
                    }
                }
                else
                {
                    Debug.Log(" Es negativo");
                    if (i % 2 == 0)
                    {
                        Debug.Log(i + " Es negativo y par");
                    }
                    else
                    {
                        Debug.Log(i + " Es negativo e impar");
                    }

                }

            }
        }
        if (numero1 < numero2)
        {
            for (int i = numero1; i <= numero2; i++)
            {
                if (i >= 0)
                {
                    if (i % 2 == 0)
                    {
                        Debug.Log(i + " Es positivo y par");
                    }
                    else
                    {
                        Debug.Log(i + " Es positivo e impar");
                    }
                }
                else
                {
                    Debug.Log(" Es negativo");
                    if (i % 2 == 0)
                    {
                        Debug.Log(i + " Es negativo y par");
                    }
                    else
                    {
                        Debug.Log(i + " Es negativo e impar");
                    }

                }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
