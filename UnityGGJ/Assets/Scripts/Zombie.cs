using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour 
{
	NavMeshAgent agente;
	Animator animador;
	Transform jugador;


	public float Velocidad = 3f; // unidades por segundo

	void Awake () {
		agente = GetComponent<NavMeshAgent>();
		animador = GetComponent<Animator>();
	}
	
	
	void Update () {
		// mantener al zombie en el piso
		transform.position = new Vector3(transform.position.x, 0, transform.position.z);

		// solo si existe jugador
		if(jugador != null) {
			// mirar hacia el jugador
			Vector3 posicionEnPiso = new Vector3(jugador.position.x,0f, jugador.position.z);
			transform.LookAt(posicionEnPiso); 
			// avanzar hacia el jugador
			transform.Translate(Vector3.forward * Velocidad * Time.deltaTime, Space.Self);

			animador.SetBool("Avanzando",true);
		} else{
			animador.SetBool("Avanzando",false);
		}
	}

	void OnTriggerEnter(Collider otro) {
		if(otro.tag=="Player") {
			jugador = otro.transform;
		}
	}

	void OnTriggerExit(Collider otro) {
		if(otro.tag=="Player") {
			jugador = null;
		}
	}
}
