using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//using UnityEngine.SceneManagement;//unity5.0

public class Colldetect : MonoBehaviour
{
    private int dead = 0;
    public GameObject deathAnimation;
    public AudioClip explosion;


    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("entercalled");

        if (col.gameObject.name == "enemyship"|| col.gameObject.tag == "wall")//if player collides with enemy kill enemy
        {

            Instantiate(deathAnimation, transform.position, transform.rotation);
            AudioSource.PlayClipAtPoint(explosion, col.collider.transform.position);

            Destroy(this.gameObject);
        }
        if (gameObject != null && col.gameObject.name != "ceiling" && col.gameObject.name != "floor" && col.gameObject.name != "sprite rocket" && col.gameObject.name != "bullet" && col.gameObject.name != "EndOfLevel")
        {
            dead = 1;
            if (dead == 1)
            {
                AudioSource.PlayClipAtPoint(explosion, col.transform.position);
                Instantiate(deathAnimation, transform.position, transform.rotation);
                Destroy(gameObject);//if player collides with enemy and is not dead kill the player
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col2)
    {
        if (col2.gameObject.name == "enemy bullet(Clone)")//if a instance of a bullet hits kill the bullet and the gameobject this is attached to(enemyships)
        {
            AudioSource.PlayClipAtPoint(explosion, col2.transform.position);
            Instantiate(deathAnimation, transform.position, transform.rotation);
            Destroy(col2.gameObject);
            Destroy(gameObject);
        }
        if (col2.gameObject.name == "Laser(Clone)")//if a instance of a bullet hits kill the bullet and the gameobject this is attached to(enemyships)
        {
            AudioSource.PlayClipAtPoint(explosion, col2.transform.position);
            Instantiate(deathAnimation, transform.position, transform.rotation);
            Destroy(gameObject);
        }


        else if (col2.gameObject.name == "EndOfLevel")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}


