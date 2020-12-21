using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rbd;

    [Range(0, 1000)]
    public float movementSpeed;
    
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }
    
    void Move()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * (Time.deltaTime * movementSpeed);
        int bonus = 1;
        if (Input.GetButtonDown("Fire2"))
            bonus = 20;
        rbd.velocity = input * bonus;
        
    }
    
}
