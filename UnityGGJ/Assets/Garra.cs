using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garra : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) {
		if(other.tag=="Player")	 {
			UIDanho danho = GameObject.FindObjectOfType<UIDanho>();
			if(danho!=null)
				danho.MostrarDanho();
		}
	}
}
