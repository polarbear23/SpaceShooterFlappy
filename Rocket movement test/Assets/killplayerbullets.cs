using UnityEngine;
using System.Collections;

public class killplayerbullets : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col6){//kills player bullets after they leave the screen
		Debug.Log ("triggered");
		if(col6.name=="bullet(Clone)"){
			Destroy (col6.gameObject);	}
		if (col6.name == "enemy bullet(Clone)") {
			Destroy(col6.gameObject);
		}
	
	}

}
