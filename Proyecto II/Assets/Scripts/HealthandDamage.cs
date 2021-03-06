using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class HealthandDamage : MonoBehaviour
{
    private SpriteRenderer sPlayer;
    private Color colorOriginal;

    public float epilepsia = 0.2f;
    private int vida;
    public bool invecible = false;
    public float tiempo_invencible = 1f;
    public float tiempo_frenado = 0.2f;
    public GameObject[] vidas;
    private Animator anim;
    public AudioSource clip;
    private void Start()
    {
        vida = 4;
        anim = GetComponent<Animator>();
        sPlayer = GetComponent<SpriteRenderer>();
        colorOriginal = sPlayer.color;
    }
    public void RestarVida(int kantidad)
    {
        
        if (!invecible && vida > 0)
        {
            vida -= 1;
            anim.Play("da?os");
            StartCoroutine(Invulnerabilidad());
            StartCoroutine(FrenarVelocidad());
            clip.Play();
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
        SceneManager.LoadScene("GameOver",LoadSceneMode.Single);
    }
    IEnumerator Invulnerabilidad () 

    {
        Color nuevocolor = new Color(217f / 255f, 81f / 255f, 81f / 255f);
        invecible = true;
        sPlayer.color = nuevocolor;
        yield return new WaitForSeconds(epilepsia);
        sPlayer.color = colorOriginal;
        yield return new WaitForSeconds(epilepsia);
        sPlayer.color = nuevocolor;
        yield return new WaitForSeconds(epilepsia);
        sPlayer.color = colorOriginal;
        yield return new WaitForSeconds(epilepsia);
        sPlayer.color = nuevocolor;
        yield return new WaitForSeconds(epilepsia);
        sPlayer.color = colorOriginal;
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
