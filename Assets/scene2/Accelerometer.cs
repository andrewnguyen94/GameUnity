using UnityEngine;
using System.Collections;

public class Accelerometer : MonoBehaviour {
	float speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float z = Input.acceleration.z;
		float y = Input.acceleration.y;
		Debug.Log (y);
		//transform.Translate (0,0, y * speed * Time.deltaTime);
		transform.Rotate (0, 0, -z * speed);
	}
}
