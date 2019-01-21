using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	Animator animator;

	void Start () {
		animator = GetComponent<Animator>();
	}
	
	void Update () {
	}

	void OnTriggerEnter( Collider other) {
		if(other.gameObject.tag == "Player") {
			animator.SetTrigger("Abrir");
		}
	}

	void OnTriggerExit( Collider other) {
		if(other.gameObject.tag == "Player") {
			animator.SetTrigger("Cerrar");
		}
	}
}
