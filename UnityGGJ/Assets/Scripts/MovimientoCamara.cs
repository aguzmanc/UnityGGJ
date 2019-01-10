using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour 
{
	Transform _player;
	Camera _cam;

	[Range(0f, 7f)]
	public float Suavidad = 3f;

	void Awake() {
		_cam = GetComponentInChildren<Camera>();
	}

	void Start() {

	}


	void Update () {
		if(_player==null) {
			_player = GameObject.FindGameObjectWithTag("Player").transform;
		}
		
		_cam.transform.LookAt(transform.position); 

		if(_player!=null)
			transform.position = Vector3.Lerp(transform.position, _player.position, Suavidad * Time.deltaTime);
	}
}
