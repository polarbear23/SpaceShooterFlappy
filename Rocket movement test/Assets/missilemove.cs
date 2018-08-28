using UnityEngine;
using System.Collections;

public class missilemove : MonoBehaviour {
	public float speed=6;
    public GameObject playership;
	private Rigidbody2D myRigidbody;
	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();//gets rigid body values of current obj

	}
	
	// Update is called once per frame
	void Update () {
		myRigidbody.velocity = new Vector2 (speed, myRigidbody.velocity.y);//gives velocity to rigidbody
     //   if (playership.transform.position.x + 6 == myRigidbody.transform.position.x)//doesnt work yet
     //   {
       //     Destroy(gameObject);
      //  }
     //   if (playership == null)
      //  {
       //     Destroy(gameObject);
      //  }
	}
}
