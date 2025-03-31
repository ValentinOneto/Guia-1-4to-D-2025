using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumaYProducto : MonoBehaviour
{
    int num1 = 4;
    int num2 = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"El resultado de la suma entre {num1} y {num2} es igual a {num1 + num2}");
        Debug.Log($"El resultado de la multiplicacion entre {num1} y {num2} es igual a {num1 * num2}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
