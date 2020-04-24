using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody physics;
    float horizontal = 0;
    float vertical = 0;
    Vector3 vector3;
    public float charspeed;
    public float minx;
    public float maxx;
    public float maxz;
    public float minz;
    public float slope;
    float fireTime = 0;
    public float timetofire;
    public GameObject bullet;
    public Transform gun_barrel;
    AudioSource audio;
    void Start()
    {
        physics = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        
        if (Input.GetButton("Fire1")&& Time.time>fireTime)
        {
            fireTime = Time.time + timetofire;
            Instantiate(bullet,gun_barrel.position, Quaternion.identity);
            audio.Play();
        }
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vector3 = new Vector3(horizontal, 0, vertical);
        physics.velocity = vector3*charspeed;

        physics.position = new Vector3
            (
            Mathf.Clamp(physics.position.x,minx,maxx),
            0.0f,
            Mathf.Clamp(physics.position.z,minz,maxz)
            );
        physics.rotation = Quaternion.Euler(0, 0, physics.velocity.x*(-slope));
    }
}
