using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class Enemy : MonoBehaviour
{


    public GameObject bullet;   //the bullet we are shooting must have a rigidbody
    public int Speed = 32000; //the speed the bullet is shot at

    //this is only used if rapid fire is set to true
    //RateOfFire privat

    Rigidbody enemyRigB;

    // Use this for initialization
    void Start()
    {
        enemyRigB = GetComponent<Rigidbody>();

        GameObject shotRapid = Instantiate(bullet, transform.position - new Vector3(2, 0, 0), Quaternion.identity);

        shotRapid.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed, 0));
    }







    // Update is called once per frame
    void FixedUpdate()
    {

        GameObject shotRapid = Instantiate(bullet, transform.position - new Vector3(2, 0, 0), Quaternion.identity);

        shotRapid.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed, 0));


    }

}
