using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainScript : MonoBehaviour
{

	public float Speed = 600;
	public bool isSpin = true;

	void Update(){

		Rotate ();
	}
   
	void Rotate(){

		transform.Rotate(0,0,  - Speed*Time.deltaTime);

		if(isSpin == false && Speed > 0)
		{
			Stop();

		}
	}

	public void Stop(){

		Speed --;
		if (Speed <= 0)
		{
			Speed = 0;
		}

	}

}
