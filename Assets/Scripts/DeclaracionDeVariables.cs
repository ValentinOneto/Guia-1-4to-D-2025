using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int edadUsuario;
    float sueldoUsuario;
    string nombreUsuario;
    bool tieneCasa;

    // Start is called before the first frame update
    void Start()
    {
        edadUsuario = 52;
        sueldoUsuario = 9999999.00f;
        nombreUsuario = "Alejandra";
        tieneCasa = true;

        Debug.Log(edadUsuario);
        Debug.Log(sueldoUsuario);
        Debug.Log(nombreUsuario);
        Debug.Log(tieneCasa);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
