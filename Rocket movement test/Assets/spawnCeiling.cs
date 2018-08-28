using UnityEngine;
using System.Collections;

public class spawnCeiling : MonoBehaviour {
    public float spawnTimeCeiling;
    public float spawnTimeFloor;
    public GameObject ceiling;
    public GameObject floor;
    private float addedOn = 22.7f;//distance between each spawn point
    private float initialpos;
    float y1 = 3.38f;//range for ceiling
    float y2 = 4.42f;//range for ceiling
    float y3 = -4.52f;//range for floor
    float y4 = -3.53f;//range for floor
    float timeLoop = 0;// how many times you have looped/divided by 10 initially set to 0
    // Use this for initialization
    void Start()
    {
        initialpos = ceiling.transform.position.x;//stores initial x value spawn point for ceilings and floors
     
    }
    void Update()
    {
        if (timeLoop < 2) { //spawns a limited number of ceilings and floors timeLoop is how many times you would like to go through the forloop 10times so 1 = 10 times and 2 = 20times
        addCeiling();//adds ceilings and floors
    }
    }
    void addCeiling()
    {
        

        
        for(int i = 1; i <= 10; i++)
        {
            initialpos = initialpos + 22.7f;//moves to next spawn loc
            addedOn = addedOn * 2;//move further to next spawn loc
            Vector2 spawnPoint = new Vector2(initialpos, Random.Range(y1, y2));//creates a spawnpoint between two ranges of y1 and y2 to simulate more of a rocky terrain like copter
            Vector2 spawnPointFloor = new Vector2(initialpos, Random.Range(y3, y4));//
            Vector2 spawnPointFloor2 = new Vector2(initialpos, -4.52f);//to make sure there are no gaps spawns another floor to cover gaps
            Instantiate(ceiling, spawnPoint, ceiling.transform.rotation);
            Instantiate(floor, spawnPointFloor, floor.transform.rotation);
            Instantiate(floor, spawnPointFloor2, floor.transform.rotation);
            
        }
        timeLoop++;
        
       
    }
 
}
