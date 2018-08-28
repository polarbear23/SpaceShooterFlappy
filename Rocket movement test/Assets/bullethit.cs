using UnityEngine;
using System.Collections;

public class bullethit : MonoBehaviour {
	public int life;//life of this object/enemy/destructable object (how many bullets it takes to kill)
	public GameObject hitAnimation;//can be a death animation like for the enemy ships or a small hitdetect particle effect
    // Use this for initialization

		

    void OnTriggerEnter2D(Collider2D col2)
    {
        if (col2.gameObject.name == "bullet(Clone)")//if a instance of a bullet hits kill the bullet and the gameobject this is attached to(enemyships)
        {
			life=life-1;
			Instantiate(hitAnimation,transform.position,transform.rotation);
			Destroy(col2.gameObject);
            if (life<=0){
            Destroy(gameObject);
				ScoreManager.score += 1;
        }

		
    }
		if (col2.gameObject.name == "destructionpoint") {
			Debug.Log("coldetected");
			Destroy(gameObject);

		
		}
		Debug.Log (life);
}


}
