using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void IniciarJuego()
    {
        SceneManager.LoadScene(1);
    }

    public void SalirJuego()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego, esperamos que vuelvas pronto");
    }

}
