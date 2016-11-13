using UnityEngine;
using System.Collections;

public class esfera : MonoBehaviour {

	public Transform Capsule;
	Vector3 temp = new Vector3(5,0,5);
	public int cuadrante;

	//var Capsule:Transform;

	// Use this for initialization
	void Start () {
		cuadrante=4;
		transform.position =temp;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.LookAt(Capsule);

		if(cuadrante==1){
	    
	    if(transform.position.z>1 && transform.position.x>1)
			{
				transform.position +=transform.forward*Time.deltaTime*2f;
				//transform.position.z-=transform.forward*Time.deltaTime*2f;
				//transform.position.x-=transform.forward*Time.deltaTime*2f;
			}else
			{
				cuadrante=Random.Range(2,4);
				if(cuadrante==1){
					Vector3 temp1 = new Vector3(Random.Range(5,10),0,Random.Range(5,10));
					transform.position =temp1;
				}else if(cuadrante==2)
				{
					Vector3 temp2 = new Vector3(Random.Range(5,10),0,Random.Range(-10,-5));
			        transform.position =temp2;
				}else if(cuadrante==3)
				{
					Vector3 temp3 = new Vector3(Random.Range(-10,-5),0,Random.Range(-10,-5));
			        transform.position =temp3;
				}else if(cuadrante==4)
				{
					Vector3 temp4 = new Vector3(Random.Range(-10,-5),0,Random.Range(5,10));
			        transform.position =temp4;
				}

			}

		}
		if(cuadrante==2){
			
			if(transform.position.z<1 && transform.position.x>1)
			{
				transform.position +=transform.forward*Time.deltaTime*2f;
				
			}else
			{
				cuadrante=Random.Range(1,4);
				if(cuadrante==1){
					Vector3 temp1 = new Vector3(Random.Range(5,10),0,Random.Range(5,10));
					transform.position =temp1;
				}else if(cuadrante==2)
				{
					Vector3 temp2 = new Vector3(Random.Range(5,10),0,Random.Range(-10,-5));
			        transform.position =temp2;
				}else if(cuadrante==3)
				{
					Vector3 temp3 = new Vector3(Random.Range(-10,-5),0,Random.Range(-10,-5));
			        transform.position =temp3;
				}else if(cuadrante==4)
				{
					Vector3 temp4 = new Vector3(Random.Range(-10,-5),0,Random.Range(5,10));
			        transform.position =temp4;
				}

			}

		}
		if(cuadrante==3){
			
			if(transform.position.z<-1 && transform.position.x<-1)
			{	
				transform.position +=transform.forward*Time.deltaTime*2f;
			}else
			{
				cuadrante=4;
				if(cuadrante==1){
					Vector3 temp1 = new Vector3(Random.Range(5,10),0,Random.Range(5,10));
					transform.position =temp1;
				}else if(cuadrante==2)
				{
					Vector3 temp2 = new Vector3(Random.Range(5,10),0,Random.Range(-10,-5));
			        transform.position =temp2;
				}else if(cuadrante==3)
				{
					Vector3 temp3 = new Vector3(Random.Range(-10,-5),0,Random.Range(-10,-5));
			        transform.position =temp3;
				}else if(cuadrante==4)
				{
					Vector3 temp4 = new Vector3(Random.Range(-10,-5),0,Random.Range(5,10));
			        transform.position =temp4;
				}

			}
		}
		if(cuadrante==4){
			
			if(transform.position.z>1 && transform.position.x<1)
			{	
				transform.position +=transform.forward*Time.deltaTime*2f;
			}else
			{
				cuadrante=Random.Range(1,3);
				if(cuadrante==1){
					Vector3 temp1 = new Vector3(Random.Range(5,10),0,Random.Range(5,10));
					transform.position =temp1;
				}else if(cuadrante==2)
				{
					Vector3 temp2 = new Vector3(Random.Range(5,10),0,Random.Range(-10,-5));
			        transform.position =temp2;
				}else if(cuadrante==3)
				{
					Vector3 temp3 = new Vector3(Random.Range(-10,-5),0,Random.Range(-10,-5));
			        transform.position =temp3;
				}else if(cuadrante==4)
				{
					Vector3 temp4 = new Vector3(Random.Range(-10,-5),0,Random.Range(5,10));
			        transform.position =temp4;
				}

			}
		}

	}
}
