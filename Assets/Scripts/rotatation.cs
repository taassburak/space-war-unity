using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatation : MonoBehaviour
{
    Rigidbody physics;
    public float speed;
    void Start()
    {
        physics = GetComponent<Rigidbody>();
        //physics.angularVelocity = Random.insideUnitSphere * speed;
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 100 * speed));
    }

}
