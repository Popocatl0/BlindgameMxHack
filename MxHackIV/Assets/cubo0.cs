using UnityEngine;
using System.Collections;

public class cubo0 : MonoBehaviour {

	// Use this for initialization
	 public float  avanzar;
     public float recorrido= 100;
     public float  valorz;
     public Vector3 temp ;
     public int cuadrante;
    
     //Random rnd = new Random();
     //valorz=rnd.Next(5,10);
     
	//public float velocidadDespzamiento=1;
    //public float velocidadGiro=1; 

	// Use this for initialization

	void Start () {
	 temp = new Vector3(Random.Range(5,10),0,Random.Range(5,10));
	cuadrante=1;
	 GetComponent<Renderer>().material.color = new Color(255, 0, 0);
	transform.position =temp;
	avanzar=1f;
	//valorz=rnd.Next(5,10);
	}

	
	// Update is called once per frame
	void Update () {
		
		if(cuadrante==1){
			//Vector3 temp1 = new Vector3(Random.Range(5,10),0,Random.Range(5,10));
			//transform.position =temp2;
			if(transform.position.z>1 && transform.position.x>1)
			{
				transform.Translate(-avanzar*Time.deltaTime,0,-avanzar*Time.deltaTime);
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
			transform.Translate(-avanzar*Time.deltaTime,0,avanzar*Time.deltaTime);	
			}else
			{
				cuadrante=Random.Range(3,4);
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
			
			if(transform.position.z<1 && transform.position.x<1)
			{	
				transform.Translate(avanzar*Time.deltaTime,0,avanzar*Time.deltaTime);
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
				transform.Translate(avanzar*Time.deltaTime,0,-avanzar*Time.deltaTime);
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

		/*if(transform.position.z>1 && transform.position.x>1){
		transform.Translate(-avanzar*Time.deltaTime,0,-avanzar*Time.deltaTime);
	    }else{
	    	Vector3 tempz = new Vector3(Random.Range(5,10),0,Random.Range(5,10));
	    	transform.position =tempz;
	    */
	    }
	
}
