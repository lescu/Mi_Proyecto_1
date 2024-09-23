using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField]int h;
    [SerializeField] int m;
    [SerializeField] int s;

    // Start is called before the first frame update
    void Start()
    {
        if (h > 24)
        {
            Debug.Log("Esta hora es inválida");
        }
        else if (m > 60)
        {
            Debug.Log("Esta hora es invalida");
        }
        else if (s > 60)
        {
            Debug.Log("Esta hora es invalida");
        }
        else
        {
            if(h == 24)
            {
                h = 0;
            }
            if (m == 60)
            {
                m = 0;
            }
            Debug.Log("Son las " + h + " h " + m + " m " + s + " s ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
