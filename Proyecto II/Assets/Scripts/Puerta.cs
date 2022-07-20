using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public GameObject noKey;
    public GameObject key;
    public GameObject btnPuerta;
    public GameObject puerta;
    public GameObject puertafisica;


    void Start()
    {
        key.SetActive(false);
        noKey.SetActive(false);
        btnPuerta.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("key"))
        {
            GetComponent<UceninMove>().item = true;
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("door") && !GetComponent<UceninMove>().item)
        {
            noKey.SetActive(true);
        }

        if (collision.tag.Equals("door") && GetComponent<UceninMove>().item)
        {
            key.SetActive(true);
            btnPuerta.SetActive(true);
            if (Input.GetKey("f"))
            {
                puertafisica.SetActive(false);
                
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("door") && !GetComponent<UceninMove>().item)
        {
            noKey.SetActive(false);
        }

        if (collision.tag.Equals("door") && GetComponent<UceninMove>().item)
        {
            key.SetActive(false);

            btnPuerta.SetActive(false);
        }
    }

    public void boton()
    {
        puerta.SetActive(false);
        
    }
}
