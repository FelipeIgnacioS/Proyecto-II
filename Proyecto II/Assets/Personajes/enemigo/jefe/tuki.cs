using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuki : MonoBehaviour
{
    public Transform player_pos;
    public float speed;
    public float distacia_frena;
    public float distancia_retraso;
    public Transform punto_instancia;
    public GameObject bala;
    private float tiempo;
    private Animator anim;

    void Start()
    {
        player_pos = GameObject.Find("Player").transform;    
    }
    void Update()
    { 
        // movimiento
        #region
        if (Vector2.Distance(transform.position, player_pos.position) > distacia_frena)
        {
            transform.position = Vector2.MoveTowards(transform.position, player_pos.position, speed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, player_pos.position) < distancia_retraso)
        {
            transform.position = Vector2.MoveTowards(transform.position, player_pos.position, - speed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, player_pos.position) < distacia_frena && Vector2.Distance(transform.position, player_pos.position) > distancia_retraso)
        {
            transform.position = transform.position;
        }
        #endregion
        // flip
        #region
        if (player_pos.position.x > this.transform.position.x)
        {
            this.transform.localScale = new Vector2(1, 1);
        }

        else
        {
                this.transform.localScale = new Vector2(-1, 1);
        }
        #endregion
        // disparo
        #region
        tiempo += Time.deltaTime;
        if (tiempo >= 0.56)
        {
            Instantiate(bala, punto_instancia.position, Quaternion.identity);
            tiempo = 0;
        }
        #endregion
    }

}
