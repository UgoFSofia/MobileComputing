using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    private float speed;
    public bool isSpin = true;
    public float maxSpeed = 600;

    public GameObject pointer;

    void Start()
    {
    	speed = maxSpeed;
    }
   

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
        isSpin = false;
    	speed --;

    	if (speed<=0)
    	{
    		pointer.GetComponent<BoxCollider> ().enabled = true;
    		speed = 0;
    	}
    }

    public void Reset()
    {
    	isSpin = true;
    	pointer.GetComponent<BoxCollider> ().enabled = false;
    	speed = maxSpeed;
    }
}
