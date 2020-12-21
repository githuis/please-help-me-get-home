using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChecker : MonoBehaviour
{

    public Enemy parent;

    private float allowedTime = 0.5f;
    private float playerTouchTime;

    private bool touchingJustVisible = false;
    
    
    void Start()
    {
        parent = transform.parent.GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
            return;

        Movement playerMovement = other.GetComponent<Movement>();
        
        if(!playerMovement.hidden)
            parent.AttackPlayer(playerMovement.GetPlayer);
    }

    private void OnTriggerStay(Collider other)
    {
        if(!other.CompareTag("Player"))
            return;
        Movement playerMovement = other.GetComponent<Movement>();
        
        if(!playerMovement.hidden)
            parent.AttackPlayer(playerMovement.GetPlayer);
        
    }
}
