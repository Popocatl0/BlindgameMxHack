using UnityEngine;
using System.Collections;

public class IABasic : MonoBehaviour {

	public GameObject target;
	public float velocidad = 7.0f;
    //NavMeshAgent agent;

    void Awake ()
    {
        //agent = GetComponent<NavMeshAgent>();

    }
	// Use this for initialization
	void Start () {
		//agent.SetDestination(target.transform.position);
		this.transform.LookAt(target.transform);
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
		transform.position += transform.forward * Time.deltaTime * velocidad;
	}
}
