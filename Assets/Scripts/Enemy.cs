using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private FindKillableEnemy inList;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddToList(FindKillableEnemy killableEnemy)
    {
        inList = killableEnemy;
    }

    private void OnDestroy()
    {
        if (inList != null)
        {
            inList.RemoveEnemy(gameObject);
        }
    }

    public void KillMe()
    {
        Destroy(gameObject);
    }

    public void AttackPlayer(PlayerManager player)
    {
        print("u ded");
        player.KillPlayer();
    }
}
