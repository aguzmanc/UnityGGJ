using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour {

	public GameObject bala;
	public Transform origenBala;

	
	void Update () {
		if  (Input.GetKeyDown("space"))
        {
			Debug.Log("disparar");
            Instantiate(bala, origenBala.position, origenBala.rotation);
        }
		
	}
}
