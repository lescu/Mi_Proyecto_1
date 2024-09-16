using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    float Pi = 3.14f;
    float radioCirc = 15.2f;
   
   
    int baseTre = 18;
    int alturaTre = 6;
   
    
    float lado = 6.8f;
     
    // Start is called before the first frame update
    void Start()
    {
        //string COMPRAENBOLSA = IrASuper(3, "AV23");
        //Debug.Log(COMPRAENBOLSA);

        float areaCirc = CalculoCirc(Pi , radioCirc);
        Debug.Log("El area del circulo es = " + areaCirc);

        int areaTre = CalculoTre(baseTre, alturaTre);
        Debug.Log("El area del triangulo es = " + areaTre);
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
