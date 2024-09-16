using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float vehiculo1;
    [SerializeField] float vehiculo2;
    [SerializeField] float vehiculo3;
    [SerializeField] float vehiculo4;
    float vehiculo1MS;
    float vehiculo2MS;
    float vehiculo3MS;  
    float vehiculo4MS;
    // Start is called before the first frame update
    void Start()
    {
        vehiculo1MS = (vehiculo1 / 1000) *3600;
        Debug.Log("vehiculo 1 = " + vehiculo1MS + "m/s");

        vehiculo2MS = (vehiculo2 / 1000) * 3600;
        Debug.Log("vehiculo 2 = " + vehiculo2MS + "m/s");

        vehiculo3MS = (vehiculo3 / 1000) * 3600;
        Debug.Log("vehiculo 3 = " + vehiculo3MS + "m/s");

        vehiculo4MS = (vehiculo4 / 1000) * 3600;
        Debug.Log("vehiculo 4 = " + vehiculo4MS + "m/s");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
