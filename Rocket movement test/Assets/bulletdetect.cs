using UnityEngine;
using System.Collections;

public class bulletdetect : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D col2)//not used script
    {
        if (col2.gameObject.name == "enemyship")
        {
            Destroy(col2.gameObject);
        }
        if (gameObject != null && col2.gameObject.name != "sprite rocket" && col2.gameObject.name != "bullet")
        {
            Destroy(gameObject);
        }
    }
}
