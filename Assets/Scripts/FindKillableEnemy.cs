using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindKillableEnemy : MonoBehaviour
{

    private List<GameObject> enemies = new List<GameObject>();

    public List<GameObject> GetEnemies => enemies;

    public bool SingleEnemy => GetEnemies.Count == 1;
    public GameObject GetSingleEnemy => enemies[0];

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Enemy"))
            return;
        
        enemies.Add(other.gameObject);
        other.gameObject.SendMessage("AddToList", this);
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (enemies.Contains(other.gameObject))
            enemies.Remove(other.gameObject);
    }

    public void RemoveEnemy(GameObject enemy)
    {
        if (enemies.Contains(enemy))
            enemies.Remove(enemy);
    }
}
