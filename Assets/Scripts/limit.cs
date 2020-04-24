using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limit : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        
    }
}
