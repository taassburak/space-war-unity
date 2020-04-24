using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smash_it : MonoBehaviour
{
    public GameObject explosion;
    public GameObject exp_player;
    GameObject GameControl;
    GameControl control;
    void Start()
    {
        GameControl = GameObject.FindGameObjectWithTag("gamecontrol");
        control = GameControl.GetComponent<GameControl>();
        
    }

    void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        Destroy(gameObject);
        Instantiate(explosion, col.transform.position, col.transform.rotation);
        control.ScoreUp(10);

        if (col.tag == "Player")
        {
            
            Instantiate(exp_player, col.transform.position, col.transform.rotation);
            control.gameover();
        }
    }


}
