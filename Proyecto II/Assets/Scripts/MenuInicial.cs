using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MenuInicial : MonoBehaviour
{
    public bool jg = false;
    public AudioSource clip;
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
        jg = true;
        clip.Play();
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
