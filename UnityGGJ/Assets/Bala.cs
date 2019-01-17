using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {


	public float velocidad = 200f;

	void Update () {
		transform.Translate(velocidad * Time.deltaTime, 0, 0);
 
	}

}
