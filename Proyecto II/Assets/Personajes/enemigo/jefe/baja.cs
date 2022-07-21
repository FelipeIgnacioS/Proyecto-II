using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baja : MonoBehaviour
{
    public float speed;
    private Rigidbody2D m_rig;
    // Start is called before the first frame update
    void Start()
    {
        m_rig = GetComponent<Rigidbody2D>();
        m_rig.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
        Invoke("destruir_", 4);

    }

    // Update is called once per frame
    void destruir_()
    {
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        destruir_();
    }
}
