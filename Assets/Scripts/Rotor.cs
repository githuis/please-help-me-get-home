using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotor : MonoBehaviour

{
    private Rigidbody rbd;
    private Pathfollower _pathfollower;

    void Start()
    {
        rbd = GetComponent<Rigidbody>();
        _pathfollower = GetComponent<Pathfollower>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_pathfollower.wayPoints.Length != 0)
            transform.LookAt(_pathfollower.currentTarget.position);
    }
}