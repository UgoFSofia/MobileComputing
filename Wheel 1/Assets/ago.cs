using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ago : MonoBehaviour
{
    
    void OnTriggerEnter(collider c)

    {
    	Debug.Log (c.gameObject.name);
    }
}
