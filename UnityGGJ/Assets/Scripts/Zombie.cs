using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour 
{
	static float DISTANCIA_ATAQUE = 1.2f;

	NavMeshAgent agente;
	Animator animador;
	Transform jugador;

	[HideInInspector] // evita que se vea en el inspector
	public bool EdicionManual = false;

	// todo lo publico se ve en el inspector para editarse
	[Range(0f, 5f)] // esto lo convierte en un slider
	public float Velocidad = 3f; // unidades por segundo

	
	void Awake () {
		agente = GetComponent<NavMeshAgent>();
		animador = GetComponent<Animator>();
	}
	
	
	void Update () {
		// no perseguir jugador si las animaciones estan controladas manualmente
		if(EdicionManual) 
			return;

		bool atacando =  animador.GetCurrentAnimatorStateInfo(0).IsName("Atacando");

		// mantener al zombie en el piso
		transform.position = new Vector3(transform.position.x, 0, transform.position.z);

		// solo si existe jugador
		if(jugador != null && atacando==false) {
			// mirar hacia el jugador
			Vector3 posicionEnPiso = new Vector3(jugador.position.x,0f, jugador.position.z);
			transform.LookAt(posicionEnPiso); 
			// avanzar hacia el jugador
			transform.Translate(Vector3.forward * Velocidad * Time.deltaTime, Space.Self);

			animador.SetBool("Avanzando",true);

			if(Vector3.Distance(posicionEnPiso, transform.position) <= DISTANCIA_ATAQUE) {
				animador.SetTrigger("Atacar");
			}
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
