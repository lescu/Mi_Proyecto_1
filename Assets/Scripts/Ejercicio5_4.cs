using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] float numero1;
    [SerializeField] float numero2;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
        if (numero2 > 0)
        {
            resultado = numero1 / numero2;
            Debug.Log(resultado);
        }
        
        else
        {
            Debug.Log("El divisor es 0, no se puede hacer la division");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
