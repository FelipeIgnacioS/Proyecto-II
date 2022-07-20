using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class faraonSc : MonoBehaviour
{
    public Transform PuntoA;
    public Transform PuntoB;

    public bool MoveToA = false;
    public bool MoveToB = false;
    public float speed;
    private UceninMove ucenin;

    
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MoveToA = true;
        ucenin = FindObjectOfType<UceninMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveToA)
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, PuntoA.position, speed * Time.deltaTime);
            if (transform.position.x == PuntoA.position.x)
            {
                MoveToA = false;
                MoveToB = true;
            }
        }
        if (MoveToB)
        {
            rb.transform.position = Vector2.MoveTowards(transform.position, PuntoB.position, speed * Time.deltaTime);
            if (transform.position.x == PuntoB.position.x)
            {
                MoveToB = false;
                MoveToA = true;
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ucenin.Hit = true;
            Destroy(gameObject);
        }
    }
}
