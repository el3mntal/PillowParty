using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaControlador : MonoBehaviour
{
    public GameObject CuadroPausa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //metodo para que se active el recuadro de pausa
    public void BotonPausar() 
    {
        CuadroPausa.SetActive(true);
    }

    //metodo para que se desactive el recuadro de pausa
    public void BontonReanudar()
    {
        CuadroPausa.SetActive(false);
    }

    //metodo para volver al menu
    public void VolverMenu()
    {
        SceneManager.LoadScene(0);
    }
}
