using UnityEngine;
using System.Collections;

public class mediumasteroidspawner : MonoBehaviour {
	public float time2;
	public GameObject asteroid3;
	public float end;//xpos of end of level to make the spawner to stop
	// Use this for initialization
	void Start () {
		InvokeRepeating("addAsteroid3",time2,time2);//continuously calls function addEnemy every so seconds according to spawnTime float variable.
	}
	void addAsteroid3()
	{
		if (transform.position.x <= end) {
			float y1 = -4.73f;//range
			float y2 = 4.73f;//range
			Vector2 spawnPoint = new Vector2 (transform.position.x + 30f, Random.Range (y1, y2));//creates a spawnpoint 20units away from gameobj script is attached to and a random y between y1-y2.
			Instantiate (asteroid3, spawnPoint, transform.rotation);
		}//spawns enemy ship at set position "spawnPoint".
	
	}// Update is called once per frame
	void Update () {
		
	}
}
