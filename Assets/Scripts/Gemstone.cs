using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemstone : MonoBehaviour
{
    public bool hasBeenClaimed;

    public GameObject graphicsObject;

    private Jukebox jq;
    
    void Start()
    {
        jq = FindObjectOfType<Jukebox>();

    }
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jq.PlayGemPickup();
            graphicsObject.SetActive(false);
            hasBeenClaimed = true;
        }
    }
}
