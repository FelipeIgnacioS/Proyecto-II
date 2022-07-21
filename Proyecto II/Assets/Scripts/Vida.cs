using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Vida : MonoBehaviour
{

    public AudioSource clip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<HealthandDamage>().SumLife();
            Destroy(gameObject, 0.5f);
            clip.Play();
        }
    }


}

