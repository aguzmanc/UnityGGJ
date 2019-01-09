using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


/* Modo editor para activar animaciones manualmente */
[CustomEditor(typeof(Zombie))]
public class ZombieEditor : Editor 
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		Zombie zombie = (Zombie)target;

		if (EditorApplication.isPlaying == false)
			return; // no mostrar botones

		if(zombie.EdicionManual==false) {
			if(GUILayout.Button("Activar Edicion Manual")) {
				zombie.EdicionManual=true;
			}
		} else {
			if(GUILayout.Button("Quitar Edicion Manual")) {
				zombie.EdicionManual=false;
			}

			if(GUILayout.Button("Caminar")){
				zombie.GetComponent<Animator>().SetBool("Avanzando",true);
			}

			if(GUILayout.Button("Quieto")){
				zombie.GetComponent<Animator>().SetBool("Avanzando",false);
			}

			if(GUILayout.Button("Atacar")){
				zombie.GetComponent<Animator>().SetTrigger("Atacar");
			}

			if(GUILayout.Button("Morir")){
				zombie.GetComponent<Animator>().SetTrigger("Morir");
			}
		}


		

	}
}
