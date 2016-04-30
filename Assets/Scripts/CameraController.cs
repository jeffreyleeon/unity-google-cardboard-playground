using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate() {
		Vector3 vec = new Vector3(0f, 0f, 1f * Time.deltaTime);
		transform.Translate(vec);
	}
}
