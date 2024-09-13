using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float longitud;
    float area;
    // Start is called before the first frame update
    void Start()
    {
        longitud = 2 * 3.14f * radio;
        Debug.Log("La londitud de la circunferencia = " + longitud);

        area = 3.14f * radio * radio;
        Debug.Log("El area de la circunferencia = " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
