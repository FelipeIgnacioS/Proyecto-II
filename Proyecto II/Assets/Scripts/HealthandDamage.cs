using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthandDamage : MonoBehaviour
{
    public int vida;
    public bool invecible = false;
    public float tiempo_invencible = 1f;
    public float tiempo_frenado = 0.2f;
    public GameObject[] vidas;
    private Animator anim;

    private void Start()
    {
        vida = vidas.Length;
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
            if (vida<1)
            {
                vidas[0].gameObject.SetActive(false);
                gameOver();
                
            }
            else if (vida< 2)
            {
                vidas[1].gameObject.SetActive(false);
            }
            else if (vida<3)
            {
                vidas[2].gameObject.SetActive(false);
            }
            
        }
      
    }
    void gameOver()
    {
        anim.Play("Muerte");
        Debug.Log("Game Over");
        SceneManager.LoadScene(3,LoadSceneMode.Single);
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

    public void SumLife()
    {
        if (vida==1)
        {
            vidas[1].gameObject.SetActive(true);
            vida++;
        }
        else if (vida==2)
        {
            vidas[2].gameObject.SetActive(true);
            vida++;
        }
    }
}
