using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    float lvl;
    [SerializeField] float exp;
    // Start is called before the first frame update
    void Start()
    {
        lvl = 32 + (9 * exp / 5);
        Debug.Log(lvl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
