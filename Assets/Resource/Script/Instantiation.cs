using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public GameObject b1 = null;
	public GameObject b2 = null;
	public GameObject b3 = null;
	// Use this for initialization
	void Start () {
		b1 = Instantiate (Resources.Load ("Prefabs/prefab_building"), new Vector3 (10, 0, 0), Quaternion.identity) as GameObject;
		b2 = Instantiate (Resources.Load ("Prefabs/prefab_building"), new Vector3 (10, 0, 0), Quaternion.identity) as GameObject;
		b3 = Instantiate (Resources.Load ("Prefabs/prefab_building"), new Vector3 (10, 0, 0), Quaternion.identity) as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
