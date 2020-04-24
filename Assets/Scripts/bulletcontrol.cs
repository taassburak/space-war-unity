using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontrol : MonoBehaviour
{
    Rigidbody physics;
    public float speed;

    void Start()
    {
        physics = GetComponent<Rigidbody>();
        physics.velocity =new Vector3(0, 0, speed);
    }

    
    void Update()
    {
        
    }
}
