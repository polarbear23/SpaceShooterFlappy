using UnityEngine;
using System.Collections;

public class enemybulletmove : MonoBehaviour {
    public float bulletspeed;
    private Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();//gets rigid body data
	
	}
	
	// Update is called once per frame
	void Update () {
        myRigidbody.velocity = new Vector2(bulletspeed,myRigidbody.velocity.y);//enters a velocity into the rigid body to make the bullet move by bulletspeed
	}
}
