using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oroSec = 7;
    int SecEnMin = 60;
    int totalOro;
    // Start is called before the first frame update
    void Start()
    {
        totalOro = oroSec * (60 * 60 * 4);
        Debug.Log("Oro Total = " + totalOro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
