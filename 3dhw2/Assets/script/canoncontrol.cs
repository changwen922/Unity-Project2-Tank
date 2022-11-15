using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canoncontrol : MonoBehaviour
{	
	int linearcount = 0,angularcount = 0;
	
	bool forward = true,turn = false,targetfound = false;
	
	float period1;
	float period2;
	
	
	void Start () {
		period1 = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		
		if( !targetfound ){
			if( linearcount < 200 && forward ){
				transform.Translate(transform.forward*0.125f,Space.World);
				linearcount ++;
			}
	
			if( linearcount == 200 && !turn ){ 
				turn = true;
				forward = false;
			}
			if( turn ){
				transform.Rotate(new Vector3(0,1,0),2.0f);
				angularcount ++;
				
				if( angularcount == 90 ){
					angularcount = 0;
					linearcount = 0;
					forward = true;
					turn = false;
				}
			}	
		}
			
		
	}
	
}