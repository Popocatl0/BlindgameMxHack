using UnityEngine;
using System.Collections;

public class Jugador : MonoBehaviour {

	public GameObject bullet;
	public AudioClip[] sound;//0 disparo, 1 deteccion, 2 daño, 3powerup, 
	float bulletSpeed = 70.0f;
	float bulletLife = 7.0f;
	float lastShoot = 0.0f;
	float shootTime = 1.0f;

	float lastHit = 0.0f;
	float hitTime = 3.0f;

	Camera camara;
	AudioSource source;
	// Use this for initialization
	void Start () {
		camara = this.GetComponentInChildren<Camera> ();
		source = this.GetComponent<AudioSource>() as AudioSource;
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast(Camera.main.transform.position, camara.transform.forward, out hit, Mathf.Infinity) && Time.time - lastHit > hitTime) {
			source.PlayOneShot (sound [1]);
			lastHit = Time.time;
		}
		Disparo ();
	}

	void Disparo(){
		
		if (Input.GetKeyDown (KeyCode.Space) && Time.time - lastShoot > shootTime) {
			var newBullet = Instantiate(bullet, camara.transform.position, this.transform.rotation) as GameObject;
			newBullet.GetComponent<Rigidbody> ().velocity = this.transform.forward * bulletSpeed;
			source.PlayOneShot (sound [0]);
			Destroy (newBullet.gameObject, bulletLife);
			lastShoot = Time.time;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Enemigo(Clone)") {
			Destroy (other.gameObject);
		}
	}

}
