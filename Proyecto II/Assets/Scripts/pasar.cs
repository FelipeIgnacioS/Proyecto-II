using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasar : MonoBehaviour
{
    public string SceneName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            SceneManager.LoadScene(SceneName);
            GetComponent<UceninMove>().item = false;

        }
    }
}
