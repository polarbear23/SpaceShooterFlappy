using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{

    public GameObject EnemyBullet;//gets bullet ready for instantiating
    public GameObject Laser;
    public float shotDelay;//delay between each shot
    private float nextFire = 1.0f;// time until next shot
    public float SpecialShotDelay;//delay between each shot
    private float nextSpecialFire = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + shotDelay;
            Instantiate(EnemyBullet, transform.position, transform.rotation);
        }

        if (Time.time > nextSpecialFire)
        {
            nextSpecialFire = Time.time + SpecialShotDelay;
            Instantiate(Laser, transform.position, transform.rotation);
        }
    }
}
