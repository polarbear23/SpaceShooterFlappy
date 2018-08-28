using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	
	private Rigidbody2D myRigidbody;
	public float BossSpeed;
    public float xSpeed=0;
    public GameObject cam;
	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	
	
	
	// Update is called once per frame
	void FixedUpdate(){
		if (transform.position.y <= -2.44) {
            if (BossSpeed == -2)
            {
                BossSpeed = -BossSpeed;
            }
        }
		if (transform.position.y >= 2.44) {
           
            if (BossSpeed == 2)
            {
                BossSpeed = -BossSpeed;
            }
        }
        if (transform.position.x <= cam.transform.position.x)
        {
            if (xSpeed == -2)
            {
                xSpeed = 3;
            }
            if (xSpeed == 0)
            {
                xSpeed = 3;
            }
        }
        if (transform.position.x >= cam.transform.position.x + 10) 
        {

            if (xSpeed == 3)
            {
                xSpeed = -2;
            }
        }
        myRigidbody.velocity = new Vector2 (xSpeed, BossSpeed);
		
	}
}