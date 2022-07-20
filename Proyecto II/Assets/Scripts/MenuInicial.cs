using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public bool jg = false;
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
        jg = true;
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
