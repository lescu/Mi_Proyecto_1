using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero1;
    int numero2;
    int numero3;
    // Start is called before the first frame update
    void Start()
    {
        int numero2 = numero1 * 2;
        int numero3 = numero1 * 3;
        Debug.Log("El doble = " + numero2);
        Debug.Log("El triple = " + numero3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
