using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col4)//kills objects after they leave screen camera
    {
        Debug.Log("coldet");
        if (col4.collider.tag != "wall" || col4.collider.tag != "wall")
        {
            Destroy(col4.gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D col5)
    {//kills enemy bullets after they leave the screen
        Debug.Log("triggered");
        if (col5.tag != "wall" || col5.tag != "wall")
        {
            Destroy(col5.gameObject);
        }
    }
}
