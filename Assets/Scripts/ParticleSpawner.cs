using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public GameObject projectilePrefab;
    [Range(0, 10)] public float duration;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Spawn()
    {
        Spawn(transform.position);
    }

    public void Spawn(Vector3 pos)
    {
        GameObject part = Instantiate(projectilePrefab, pos, Quaternion.identity);
        StartCoroutine(DestroyObjectAfter(part, duration));
    }

    IEnumerator DestroyObjectAfter(GameObject target, float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(target);
    }
}
