using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;//unity 5.0+
public class PlayerMovement : MonoBehaviour {
	public float movespeed;
	public float jumpForce;
	public float maxFallSpeed;
	private Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
	}
	void FixedUpdate(){
		myRigidbody.velocity = new Vector2 (movespeed, myRigidbody.velocity.y);
		if (myRigidbody.velocity.y <= -maxFallSpeed) {
			myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, -maxFallSpeed);
		}
	}
	// Update is called once per frame
	void Update () {


	

		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown (KeyCode.Space)) {//for get mouse button 0 is left mouse button these are the controls for moving up or bouncing the player up
			myRigidbody.velocity = new Vector2(myRigidbody.velocity.x,myRigidbody.velocity.y + jumpForce);

		}

	}
   
}
