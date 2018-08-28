using UnityEngine;
using System.Collections;

public class SmallAstSpawner : MonoBehaviour {
	public float time1;
	public GameObject asteroid1;
	public float end;//end of level so spawner will stop spawning
	// Use this for initialization
	void Start () {
		InvokeRepeating("addAsteroid",time1,time1);//continuously calls function addEnemy every so seconds according to spawnTime float variable.
	}
	void addAsteroid()
	{
		if (transform.position.x <= end) {
			float y1 = -4.73f;//range
			float y2 = 4.73f;//range
			Vector2 spawnPoint = new Vector2 (transform.position.x + 25f, Random.Range (y1, y2));//creates a spawnpoint 20units away from gameobj script is attached to and a random y between y1-y2.
			Instantiate (asteroid1, spawnPoint, transform.rotation);
		}//spawns enemy ship at set position "spawnPoint".
	}
	// Update is called once per frame
	void Update () {
		
	}
}
