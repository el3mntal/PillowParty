using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class contadorMonedaOro : MonoBehaviour
{

    //creacion de instancia de la corrutina (MODIFICAR NOMBRE DE CLASS Y DE INSTANCIA PARA QUE COINCIDA CUANDO CREE OTROS SCRIPS)
    public static contadorMonedaOro instanciadatosJugador;
    public TextMeshProUGUI contadorMonedas;

    public int numeroMonedas = 0;

    private void Awake()
    {
        if (instanciadatosJugador == null)
        {
            instanciadatosJugador = this;
        }
    }

    public void IncrementarMoneda(int m)
    {
        numeroMonedas += m;
        contadorMonedas.text = "" + numeroMonedas;
    }
}
