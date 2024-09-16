using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        //string COMPRAENBOLSA = IrASuper(3, "AV23");
        //Debug.Log(COMPRAENBOLSA);

        float areaCirc = CalculoCirc(3.14f , 15.2f);
        Debug.Log("El area del circulo es = " + areaCirc);

        int areaTre = CalculoTre(18, 3);
        Debug.Log("El area del triangulo es = " + areaTre);

        float areaCuadra = CalculoCuadra(6.8f);
        Debug.Log("El area del cuadrado es = " + areaCuadra);
    }

    float CalculoCirc(float Pi, float radioCirc)
    {
        float CalculoACirc= (radioCirc * radioCirc) * Pi;
        return CalculoACirc;

    }

    int CalculoTre(int baseTre, int alturaTre)
    {
        int CalculoATre = (baseTre * alturaTre) / 2;
        return CalculoATre;
    }

    float CalculoCuadra(float lado)
    {
        float CalculoCuadra = lado * lado;
        return CalculoCuadra;
    }


    //string IrASuper(float dinero, string codigo)
    //{
    //    string compraCARRITP = "Huesito";
    //    return compraCARRITP;
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
