using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

    public GameObject EnemyBullet;//gets bullet ready for instantiating
    public float shotDelay = 1.5f;//delay between each shot
    private float nextFire = 1.0f;// time until next shot
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + shotDelay;
            Instantiate(EnemyBullet,transform.position,transform.rotation);
        }
	}
}
