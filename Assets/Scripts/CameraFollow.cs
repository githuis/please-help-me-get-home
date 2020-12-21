using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3f;
 
    private Vector3 velocity = Vector3.zero;
    private Vector3 offset = new Vector3(0, 11, -14);


    private void Awake()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    void Update ()
    {
        Vector3 goalPos = target.position;// + offset;
        transform.position = Vector3.SmoothDamp (transform.position, goalPos, ref velocity, smoothTime);
    }

    public float GetY()
    {
        return transform.rotation.eulerAngles.y;
    }
}
