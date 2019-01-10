using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDanho : MonoBehaviour 
{
	Image imagen;
	float tiempoRestante;

	[Range(0.1f, 3f)]
	public float Desvanecimiento=1f;

	void Awake() {
		imagen = GetComponentInChildren<Image>();
	}


	void Update() {
		float p = tiempoRestante/Desvanecimiento;
		imagen.color = Color.Lerp(Color.red, Color.clear, 1-p);

		tiempoRestante -= Time.deltaTime;
		tiempoRestante = Mathf.Max(0f, tiempoRestante);
	}


	public void MostrarDanho() {
		tiempoRestante = Desvanecimiento;
	}
}
