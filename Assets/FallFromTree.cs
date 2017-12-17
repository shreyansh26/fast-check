using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Move the coconut down every frame until it stops.
public class FallFromTree : MonoBehaviour {
	private Vector3 _startPosition;
	// Use this for initialization
	void Start () {
		_startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > 0.6f) {
			transform.Translate (0, -2.5f * Time.deltaTime, 0, Space.World);
		}
		//transform.position = _startPosition + new Vector3 (0, -1+Mathf.Sin(4*Time.time), 0);
	}
}
