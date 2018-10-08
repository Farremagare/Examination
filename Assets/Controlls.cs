using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{
    public SpriteRenderer rend;
    public Color color; 
    public float rotationspeed = 360;
    public float movespeed = 6f;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //Skeppet svänger åt Höger och byter färg till blue
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotationspeed * Time.deltaTime);
            rend.color = Color.blue;
        }
        //skeppet svänger åt vänster och byter färg till grön (svänger dubbelt så långsammare än höger)
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationspeed/2 * Time.deltaTime);
            rend.color = Color.green;
        }
        //gör så att skeppet åker frammåt hela tiden
        transform.Translate(0, movespeed * Time.deltaTime, 0, Space.Self);
        //gör så att skeppet åker dubbelt så långsamt som den ursprungliga farten
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -movespeed/2 * Time.deltaTime, 0, Space.Self);
        }
        //gör så att skeppet åker dubbelt så snabbt som den ursprungliga farten
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, movespeed/2 * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rend.color = new Color (Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
        }


    }

}
