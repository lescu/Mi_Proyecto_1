using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    // Start is called before the first frame update
    void Start()
    {
        if (tipo == 1)
        {
            Debug.Log("da�o = 350, vida = 650");
        }
        else if (tipo == 2)
        {
            Debug.Log("da�o = 300, vida = 550");
        }
        else if (tipo == 3)
        {
            Debug.Log("da�o = 300, vida = 500");
        }
        else if (tipo == 4)
        {
            Debug.Log("da�o = 310, vida = 460");
        }
        else if (tipo == 5)
        {
            Debug.Log("da�o = 280, vida = 490");
        }
        else if (tipo == 6)
        {
            Debug.Log("da�o = 360, vida = 520");
        }
        else
        {
            Debug.Log("No exixte ningun enemigo con esa enumeracion. Prueba otra vez.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
