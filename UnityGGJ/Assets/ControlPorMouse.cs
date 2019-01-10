using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPorMouse : MonoBehaviour 
{
	void Update () {
		Camera cam = Camera.main;
		if(cam==null) return;

		Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		if(Physics.Raycast(ray, out hit)){
			//if(hit.collider.tag == "Piso"){
				Debug.DrawLine(ray.origin, hit.point, Color.red);
				Debug.DrawRay(hit.point, Vector3.up * 5f, Color.red);
			//}
		}

		
	}
}
