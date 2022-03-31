using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej6 : MonoBehaviour
{

    //Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
    //en una variable llamada num1 y muestre un mensaje por pantalla indicando 
    //"el  número es par" o "el número es impar". Deberá utilizar el operador “módulo” 
    //es el caracter  %.


    // Start is called before the first frame update

    public int num1;
    
    void Start()
    {
     
        if (num1 <= 0)
        {
            Debug.Log("El numero es negativo o 0");
        }
        else
        {
            if (num1 % 2 == 0)
            {
                Debug.Log("El número es par");
            }
            else
            {
                Debug.Log("El número es impar");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
