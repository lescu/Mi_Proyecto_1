using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    int numero = 4;
    string texto = "Hola";
    float deci = 3.14f;
    
    //Vienen de la misma "fabrica". Del script personaje.
    //clase + objeto
    [SerializeField]Personaje link;
    [SerializeField]Personaje mario;
    
    // Start is called before the first frame update
    void Start()
    {
//        //Link's life
//        link.nombre = "Link";
//        link.Vida = 100;
//        link.velocidad = 33;
        
        
//        mario.vida = 50;
//        mario.velocidad = 10;

//        link.Mover(3,1,0);
//        link.Saltar();
//        link.Atacar();


//        //transform's position x
//        transform.position.x;
    }
}
