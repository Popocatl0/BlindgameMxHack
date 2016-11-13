using UnityEngine;
using System.Collections;

public class ControlCamara : MonoBehaviour {
	
	float rotationCamara = 10.0f;
	const float VEL_CAM = 1.2f;
	float velocidadCamara = VEL_CAM;
	float tapTime = 1.0f;
	float lastTap = 0.0f;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		CamaraRotation ();
	}

	void CamaraRotation(){
		bool tapping = false;
		if (Input.GetKeyUp (KeyCode.RightArrow) || Input.GetKeyUp (KeyCode.LeftArrow)) {
			velocidadCamara = VEL_CAM;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)) {
			if((Time.time - lastTap) < tapTime){
				tapping = true;
			}
			lastTap = Time.time;
		}
		if (tapping) {
			velocidadCamara = VEL_CAM * 4;
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate(0, rotationCamara * velocidadCamara * Time.deltaTime, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Rotate(0, rotationCamara * velocidadCamara * Time.deltaTime * -1, 0);
		}
	}
		
}
