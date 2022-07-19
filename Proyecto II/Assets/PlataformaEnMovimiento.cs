using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlataformaEnMovimiento : MonoBehaviour
{
    public GameObject ObjetoAmover;
    
    public Transform StartPoint;
    public Transform Endpoint;

    public float Velocidad;

    private Vector3 MoverHacia;

    // Start is called before the first frame update
    void Start()
    {
        MoverHacia=Endpoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        ObjetoAmover.transform.position = Vector3.MoveTowards(ObjetoAmover.transform.position, MoverHacia, Velocidad * Time.deltaTime);
        if(ObjetoAmover.transform.position==Endpoint.position)
        {
            MoverHacia = StartPoint.position;
        }
        if (ObjetoAmover.transform.position == StartPoint.position)
        {
            MoverHacia = Endpoint.position;
        }
    }
}