using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string Convertir = Conversion(65.2f, "/h");
        Debug.Log(Convertir);
    }
    string Conversion(float km, string h)
    {
        string ConversionOp = (km * 1000f) / 3600f + "m/s";
        return ConversionOp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
