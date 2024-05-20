using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    //movimiento arriba/abajo de las tuberias (0 no moverse)
    public float speed = 0;
    // tiempo de cambio de movimiento tuberias
    public float switchTime = 2;
    // Start is called before the first frame update

    private float distanceToDestroy = 48;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        InvokeRepeating("SwitchMovement", 0, switchTime);
    }

    void SwitchMovement(){
        GetComponent<Rigidbody2D>().velocity *= -1;
    }

    void Update(){
        float xcam = Camera.main.transform.position.x;
        float xpipe = this.transform.position.x;
        if(xcam > xpipe + distanceToDestroy){
            Destroy(this.gameObject);
        }
    }

}
