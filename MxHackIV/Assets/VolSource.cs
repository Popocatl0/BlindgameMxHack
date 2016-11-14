using UnityEngine;
using System.Collections;

public class VolSource : MonoBehaviour {

	public GameObject player;
	AudioSource source;
	public static int score = 0;


	// Use this for initialization
	void Start () {
		source = this.GetComponent<AudioSource>() as AudioSource;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerFront = player.transform.forward;
		Vector3 sourceFront = transform.forward;
		float beta = Vector3.Angle (sourceFront, playerFront);
		float vol = (beta * 0.7f) / 180;
		source.volume = 0.3f + vol;
	}

	void OnTriggerEnter(Collider other) {
		//Muere si es una bala
		if(other.name == "Bullet(Clone)"){
			//sonido de muerte
			score ++;
			Destroy (this.gameObject);
			Destroy (other.gameObject);
		}
	}
}

