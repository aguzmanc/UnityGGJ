using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

	public float velocidad = 200f;

	void Update () {
		transform.Translate(0, 0, velocidad * Time.deltaTime, Space.Self);
	}

}
