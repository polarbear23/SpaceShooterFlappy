using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public GameObject Projectile;
	private Rigidbody2D myRigidbody;//rigid body to get values for velocity
    public AudioClip shootSound;//pewpew.
    private AudioSource source;
    private float volLowRange=.3f;
    private float volHighRange=0.6f;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

   
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")&&Time.time>nextFire)
        {//press enter to shoot
            nextFire = Time.time + fireRate;
            float vol = Random.Range(volLowRange,volHighRange);
             Instantiate(Projectile, transform.position, transform.rotation);//instantiate bullet
            source.PlayOneShot(shootSound, vol);

        }
    }
}
