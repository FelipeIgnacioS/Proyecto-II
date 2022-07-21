using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public AudioSource clip;
    public void creditos()
    {
        SceneManager.LoadScene("Creditos");
        clip.Play();
    }
}
