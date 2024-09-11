using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int Punt1 = 13;
    int Punt2 = 17;
    int Punt3 = 8;
    float media;
    // Start is called before the first frame update
    void Start()
    {
        float media = (Punt1 + Punt2 + Punt3) / 3f;
        Debug.Log("media = " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
