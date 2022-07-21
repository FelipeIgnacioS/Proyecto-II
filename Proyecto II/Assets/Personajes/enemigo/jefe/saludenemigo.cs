using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saludenemigo : MonoBehaviour
{
    [SerializeField] private GameObject Stacy;
    [SerializeField] private GameObject egg;

    public int bida;
    public bool invencible = false;
    private Animator anim;
    void Start()
    {
    }
    public void menosvida(int cantid)
    {
        bida -= cantid;
        if (bida < 1)
        {
            anim.Play("dead");
            Destroy(egg);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
