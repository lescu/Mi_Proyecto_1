using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
         string conversionEur =  ConvertirEur(40.5f, " Euro");
        Debug.Log(conversionEur);

        string conversionUs = ConvertirUs(20.65f, " Dollar");
        Debug.Log(conversionUs);
    }

    string ConvertirEur(float CantidadEur, string Eur)
    {
        string OperarConversionEur = CantidadEur  * 1.11f + " dollar";
        return OperarConversionEur;
    }

    string ConvertirUs(float CantidadUs, string dollar)
    {
        string OperarConversionUs = CantidadUs * 0.9f + " Euro";
        return OperarConversionUs;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
