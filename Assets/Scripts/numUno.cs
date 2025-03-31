using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numUno : MonoBehaviour

{
    int num1=0;
    int resultado;

    // Start is called before the first frame update
    void Start()
    {
        num1 = num1 + 2;
        Debug.Log($"El numero mas 2 es: {num1}");

        Debug.Log($"El numero multiplicado por si mismo es: {num1 * num1}");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
