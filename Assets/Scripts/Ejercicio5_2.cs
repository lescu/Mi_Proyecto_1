using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 >= 4)
        {
         if (numero2 >= 4)
            {
                Debug.Log("Ambos numeros son mayores a 3");
            }
         else if (numero2 <4)
            {
                Debug.Log("Uno de los numeros es menor a 3");
            }
        }
        else if(numero2 >= 4)
        {
            Debug.Log("Uno de los numeros es menor a 3");
        }
        else
        {
            Debug.Log("ninguno de los numeros es mayor a 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
