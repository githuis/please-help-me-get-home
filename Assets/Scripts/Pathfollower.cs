using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfollower : MonoBehaviour
{
    public bool waitAtEveryPoint;

    public Transform[] wayPoints;
    public Transform currentTarget;


    private Vector3 startPos;
    private float startTime;

    private float journeyLength;
    private int current = -1;
    private int len => wayPoints.Length;
    private bool reached = false;

    [Range(0, 100)] public float moveSpeed;
    [Range(0, 5)] public float waitDuration;

    void Start()
    {
        SelectNextPoint();
    }

    void Update()
    {
        MoveTowards();
    }

    void SelectNextPoint()
    {
        if (len == 0)
        {
            Debug.LogWarning($"{name} has no waypoints!" );
            return;
            
        }
        current++;
        current %= len;

        reached = false;
        currentTarget = wayPoints[current];
        startPos = transform.position;
        startTime = Time.time;
        journeyLength = Vector3.Distance(startPos, currentTarget.position);
    }

    void MoveTowards()
    {
        if (len == 0)
        {
            return;
        }
        
        float distCovered = (Time.time - startTime) * moveSpeed;
        float frac = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startPos, currentTarget.position, frac);


        if (frac > 0.98f && !reached)
        {
            reached = true;
            ReachedWayPoint();

        }
    }

    void ReachedWayPoint()
    {
        if (!waitAtEveryPoint)
            SelectNextPoint();
        else 
        {
            StartCoroutine(ReachedPoint());
        }
    }

    IEnumerator ReachedPoint()
    {
        yield return new WaitForSeconds(waitDuration);
        SelectNextPoint();
    }
}