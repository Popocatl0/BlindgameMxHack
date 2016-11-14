using UnityEngine;
using System.Collections;

public class Init : MonoBehaviour {

	public GameObject spawner;
	public GameObject player;
	// Use this for initialization
	void Start () {
		spawner.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			spawner.SetActive (true);
			this.gameObject.SetActive (false);
		}
	}
}
