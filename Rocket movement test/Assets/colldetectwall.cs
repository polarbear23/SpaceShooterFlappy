using UnityEngine;
using System.Collections;

public class colldetectwall : MonoBehaviour {
    private int dead = 0;//whether object is dead or not stored as an int true=1 false=0
    public GameObject deathAnimation;//death animation using particle systems
    void OnCollisionEnter2D(Collision2D col3)
    {
        
        if (col3.gameObject.name == "sprite rocket"&&col3.gameObject!=null)//if player collides with wall/ if enemy collides with player
        {
            dead = 1;
            if (dead == 1)
            {
                Instantiate(deathAnimation, col3.transform.position, col3.transform.rotation);
                Destroy(col3.gameObject);//if player collides with wall kill player and instantiate particle effect for death
            }
        }
    }
}
