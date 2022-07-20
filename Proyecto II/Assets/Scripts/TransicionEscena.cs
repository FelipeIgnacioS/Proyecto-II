using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TransicionEscena : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private AnimationClip animacionFinal;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

   
    void Update()
    {
        if (GetComponent<MenuInicial>().jg)
        {
            StartCoroutine(CambiarEscena());
        }
    }

    IEnumerator CambiarEscena()
    {
        animator.SetTrigger("Iniciar");
        yield return new WaitForSeconds(animacionFinal.length);
        SceneManager.LoadScene(1);
    }
}
