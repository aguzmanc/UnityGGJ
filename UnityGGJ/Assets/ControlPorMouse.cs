using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControlPorMouse : MonoBehaviour 
{
	NavMeshAgent agente;

	void Awake() {
		agente = GetComponent<NavMeshAgent>();
	}
	


	void Update () {
		Camera cam = Camera.main;
		if(cam==null) return;


		if(Input.GetMouseButtonDown(0)) {
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);

			RaycastHit[] hits = Physics.RaycastAll(ray);

			for(int i=0;i<hits.Length;i++) {
				RaycastHit hit = hits[i];
				if(hit.collider.tag == "Piso") {
					agente.SetDestination(hit.point);
					Debug.DrawLine(ray.origin, hit.point, Color.red);
					Debug.DrawRay(hit.point, Vector3.up * 5f, Color.red);
				}
			}
		}
	}
}
