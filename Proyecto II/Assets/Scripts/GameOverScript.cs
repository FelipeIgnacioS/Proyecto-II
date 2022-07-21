using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class GameOverScript : MonoBehaviour
{
    public AudioSource clip;

    public void Menu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        clip.Play();
    }

    public void Salir()
    {
        clip.Play();
        Application.Quit();
    }
}
