using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAlineadoConCamara : MonoBehaviour 
{
	[Range(0f, 5f)]
	public float VelocidadMovimiento = 1f;

	void Update () {
		// obtiene información del teclado (input)
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");


		Vector3 adelante = Camera.main.transform.forward;
		adelante = new Vector3(adelante.x, 0f, adelante.z).normalized;
		Quaternion rot = Quaternion.LookRotation(adelante);

		Vector3 dir = rot * new Vector3(horizontal, 0, vertical);
		dir = dir.normalized;

		transform.Translate(dir * VelocidadMovimiento * Time.deltaTime, Space.World);

	}
}
