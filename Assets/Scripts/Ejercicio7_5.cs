using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (numero > 0)
        {
            while (i <= numero)
            {
                Debug.Log(i);
                i++;
            }
        }
        else
        {
            Debug.Log("El numero tiene que ser positivo");
        }
        if (numero > 0)
        {
            for (int i = 1; i <= numero; i++)
            {
                Debug.Log(i);
            }
        }
        else
        {
            Debug.Log("El numero tiene que ser positivo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
