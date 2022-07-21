using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hurtjefe : MonoBehaviour
{
    public int cant;
    [SerializeField] private GameObject Stacy;
    private Animator anim;


    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        Destroy(Stacy);
        SceneManager.LoadScene("Creditos");
    }

   
    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    { 
        Destroy(Stacy);
        SceneManager.LoadScene("Creditos");
    }
}

