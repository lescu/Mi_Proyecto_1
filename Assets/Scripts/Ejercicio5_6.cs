using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivel;
    // Start is called before the first frame update
    void Start()
    {
        if (nivel % 10 == 0)
        {
            Debug.Log("Tu Pokemon aprendio un movimiento nuevo");
        }

        else
        {
            Debug.Log("Tu pokemon aprendera un ataque cuando consiga un nvl multiplo de 10");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
