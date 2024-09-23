using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] int temp;
    // Start is called before the first frame update
    void Start()
    {
        if (temp <= 10)
        {
            Debug.Log("Estas en clima frio");
        }
        else if (temp > 10 && temp <= 20)
        {
            Debug.Log("Estas en un clima nublado");
        }
        else if  (temp > 20 && temp <= 30)
        {
            Debug.Log("Estas en un clima caluroso");
        }
        else
        {
            Debug.Log("Estas en un clima tropical");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
