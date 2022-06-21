using System.Collections;
using UnityEngine;

public class HealthandDamage : MonoBehaviour
{
    public int vida = 100;
    public bool invecible = false;
    public float tiempo_invencible = 1f;
    public float tiempo_frenado = 0.2f;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void RestarVida(int kantidad)
    {
        if (!invecible && vida > 0)
        {
            vida -= kantidad;
            anim.Play("daños");
            StartCoroutine(Invulnerabilidad());
            StartCoroutine(FrenarVelocidad());
            if (vida == 0)
            {
                gameOver();
            }
        }
    }
    void gameOver()
    {
        Debug.Log("Game Over");
        Time.timeScale = 0;
    }
    IEnumerator Invulnerabilidad () 

    {
        invecible = true;
        yield return new WaitForSeconds(tiempo_invencible);
        invecible = false;
    }
    IEnumerator FrenarVelocidad()
    {
        var velocidadActual = GetComponent<UceninMove>().runSpeed;
        GetComponent<UceninMove>().runSpeed = 0;
        yield return new WaitForSeconds(tiempo_frenado);
        GetComponent<UceninMove>().runSpeed = velocidadActual;


    }
}
