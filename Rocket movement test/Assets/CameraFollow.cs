using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CameraFollow : MonoBehaviour
{
    public GameObject objectToFollow;//object camera is following for this game it is following the player
    private float previousPosition;// the previous position of the object
    private float amountToMove;//amount camera has to move to keep up
    private float WaitForAnim = 3.0f;// time until Anim Finish
                                  // Use this for initialization
    void Start()
    {
        if (objectToFollow != null)
        {

            previousPosition = objectToFollow.transform.position.x;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (objectToFollow != null)
        {

            amountToMove = objectToFollow.transform.position.x - previousPosition;//calcs amount to move camera by based on ships new position from its last position 
            transform.position += new Vector3(amountToMove + 7f, 0f, 0f);//moves camera
            previousPosition = transform.position.x;//resets prev position to a new position where the ship is in the present
        }
        if (objectToFollow == null)
        {

            if (Time.time > WaitForAnim)
            {
                SceneManager.LoadScene(0);


            }

        }
    }
}
