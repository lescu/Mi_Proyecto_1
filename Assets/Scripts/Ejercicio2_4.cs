using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 25;
    // Start is called before the first frame update
    void Start()
    {
        vidas += 77;
        Debug.Log(" + 77 = " + vidas);
        
        vidas -= 3;
        Debug.Log(" - 3 = " + vidas);

        vidas *= 4;
        Debug.Log(" * 4 = " + vidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
