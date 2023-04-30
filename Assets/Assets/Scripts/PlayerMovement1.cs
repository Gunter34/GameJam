using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
   public bool isGrounded;

    void OnCollisionEnter()
    {		
		isGrounded = true;
		
    }


    void Update()
    {
					
		if (isGrounded)
		{
			isGrounded=false;
			GetComponent<Rigidbody>().AddForce(new Vector3(0,500,0));
		}		
		if (isGrounded = false)
		{
			isGrounded=false;
			GetComponent<Rigidbody>().AddForce(new Vector3(0,-500,0));
		}	
    }
}
