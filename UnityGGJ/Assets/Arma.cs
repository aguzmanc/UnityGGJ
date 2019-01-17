using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour {

	public GameObject bala;
	public Transform origenBala;

	
	void Update () {
		if  (Input.GetKeyDown("space"))
        {
            GameObject x = Instantiate(bala, origenBala.position, origenBala.rotation);
			Destroy(x, 3);
        }
		
	}
}
