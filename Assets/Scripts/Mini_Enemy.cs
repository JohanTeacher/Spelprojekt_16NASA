using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini_Enemy : MonoBehaviour
{


    public GameObject bullet;   //the bullet we are shooting must have a rigidbody
    public int Speed = 20; //the speed the bullet is shot at
    public int health = 10;
    public float timeLeft = 10.0f;

    public int ammo = 10;
    public int ammo_Counter;


    public int y_axel;
    public int duck;
    Rigidbody2D enemyRigB;



    // Start is called before the first frame update
    void Start()
    {
        enemyRigB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        GameObject shotRapid = Instantiate(bullet, transform.position - new Vector3(0, 1, 0), Quaternion.identity);

        shotRapid.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed, 0));


    }





   // void OnCollisionEnter(Collision collision)
    //{
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        //if (collision.gameObject.tag == "Player")
        //{
            //If the GameObject's name matches the one you suggest, output this message in the console

      //      GameObject shotRapid = Instantiate(bullet, transform.position - new Vector3(0, 1, 0), Quaternion.identity);

        //    shotRapid.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed, 0));


        //}


    //}
}
