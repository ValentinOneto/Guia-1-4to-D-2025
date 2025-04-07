using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simulacro : MonoBehaviour
{
    public string moneda;
    public float cantidad;
    float cotizacionMonedaElegida;
    float montoConvertido;
    float montoMinimo = 1000;
    float cotizacionDolar = 1000;
    float cotizacionEuro = 1200;
    float cotizacionReal = 200;

    // Start is called before the first frame update
    void Start()
    {
        // 1 dolar: 1000 pesos, 1 real: 200 pesos, 1 euro: 1200

        moneda = moneda.ToLower();
    if (cantidad < montoMinimo)
        {
            Debug.Log($"El monto mínimo es $1000");
            return;
        }

        if (moneda == "d")
        {
            cotizacionMonedaElegida = cotizacionDolar;
        }
    else if (moneda == "r")
        {
            cotizacionMonedaElegida = cotizacionReal;
        }
    else if (moneda == "e")
            {
                cotizacionMonedaElegida = cotizacionEuro;
            }
    
    else
        {
            Debug.Log($"Opción de moneda extranjera no válida");
            return;
        }

        montoConvertido = cantidad / cotizacionMonedaElegida;
        Debug.Log($"Tu monto convertido es: {montoConvertido}");

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
