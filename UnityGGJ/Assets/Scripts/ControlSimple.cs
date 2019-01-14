using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSimple : MonoBehaviour 
{
	[Range(20f, 80f)]
	public float VelocidadRotacion = 40f; // Grados por segundo

	[Range(0f, 5f)]
	public float VelocidadMovimiento = 1f;


	Animator animador;

	void Awake() {
		animador = GetComponentInChildren<Animator>();
	}


	void Update () {
		// obtiene información del teclado (input)
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		vertical = Mathf.Abs(vertical); // solo valor positivo para ir hacia adelante
		
		// rota el jugador
		transform.Rotate(0f, VelocidadRotacion * Time.deltaTime * horizontal, 0f);
		// mueve hacia adelante
		transform.Translate(0f, 0f, VelocidadMovimiento * vertical * Time.deltaTime, 
			Space.Self);


		// anima según la velocidad
		if(animador!=null) {
			animador.SetFloat("Velocidad", vertical);
		}
	}
}
