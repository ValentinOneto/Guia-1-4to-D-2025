﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class divisionProhibida : MonoBehaviour
{
    public int num1;
    public int num2;
    float resultado;

    // Start is called before the first frame update
    void Start()
    {
        if(num2 != 0)
        {
            resultado = num1 *1.0f / num2;
            Debug.Log($"{num1} / {num2} = {resultado}");
        }
        else
        {
            Debug.Log("No se puede dividir por cero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
