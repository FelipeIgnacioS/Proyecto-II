using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtBox : MonoBehaviour
{

    [SerializeField] private GameObject Stacy;
    [SerializeField] private GameObject egg;

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(Stacy);

        }
    }
    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(Stacy);
        }
    }
}
