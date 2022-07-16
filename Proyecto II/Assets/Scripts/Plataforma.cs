using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float startWaitTime;
    private float waitedTtime;

    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp("s"))
        {
            waitedTtime = startWaitTime;
        }



        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            if (waitedTtime <= 0)
            {
                effector.rotationalOffset = 100f;
                waitedTtime = startWaitTime;
            }
            else
            {
                waitedTtime -= Time.deltaTime;
            }
        }

        if (Input.GetKey("space") || Input.GetKey("w"))
        {
            effector.rotationalOffset = 0;
        }

    }

}
