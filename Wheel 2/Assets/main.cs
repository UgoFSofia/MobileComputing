using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public float speed = 600;
    public bool isSpin = true;
    public GameObject pointer;
   

    void Update()
    {

    	Rotate();
        
    }

    void Rotate()
    {
    		transform.Rotate(0,0, 0-speed*Time.deltaTime);

    		if( isSpin==false && speed > 0)
    		{
    			Stop();
    		}


    }

    public void Stop()
    {
    	speed --;

    	if (speed<=0)
    	{
    		pointer.GetComponent<BoxCollider> ().enabled = true;
    		speed = 0;
    	}
    }
}
