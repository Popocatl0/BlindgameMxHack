using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

    public GameObject enemie;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
	public int maxEnemies;
	public float vel = 30.0f;
    public bool stop;

    int randEnemy;

    void Start ()
    {
        StartCoroutine(waitSpawner());

    }

    void Update ()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
		this.transform.RotateAround (Vector3.zero, Vector3.up, 25.0f * Time.deltaTime * vel);
    }

    IEnumerator waitSpawner ()
    {
        yield return new WaitForSeconds (startWait);

        while (!stop)
		{	
			if (GameObject.FindGameObjectsWithTag ("Respawn").Length < maxEnemies) {
				
	            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 10, Random.Range(-spawnValues.z, spawnValues.z));
				GameObject enem = Instantiate(enemie, this.transform.position + spawnPosition, Quaternion.identity) as GameObject;
			}

            yield return new WaitForSeconds(spawnWait);
        }
    }
    
}
