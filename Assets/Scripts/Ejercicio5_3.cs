using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
       if (numero <= 0)
        {
            if (numero <= 9)
            {
                Debug.Log("El numero se encuentra entre el 0 y el 9");
            }

            else
            {
                Debug.Log("El numero se pasa de 9");
            }

        }

       else
        {
            Debug.Log("El numero es menor a 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
