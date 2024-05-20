using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Objetivo que la camara debe seguir
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(target.position.x, this.transform.position.y, this.transform.position.z);
    }
}
