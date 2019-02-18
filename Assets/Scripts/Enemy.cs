using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Timers;






public class Enemy : MonoBehaviour
{


    public GameObject bullet;   //the bullet we are shooting must have a rigidbody
    public int Speed = 20; //the speed the bullet is shot at
    public int health = 10;
    public float timeLeft = 10.0f;

    public int ammo = 10;
    public int ammo_Counter;


    public int y_axel;
    public int duck;

    public GameObject Health10;
    public GameObject Health9;
    public GameObject Health8;
    public GameObject Health7;
    public GameObject Health6;
    public GameObject Health5;
    public GameObject Health4;
    public GameObject Health3;
    public GameObject Health2;
    public GameObject Health1;




    //this is only used if rapid fire is set to true
    //RateOfFire privat

    Rigidbody enemyRigB;

    // Use this for initialization
    void Start()
    {
        enemyRigB = GetComponent<Rigidbody>();

        //GameObject shotRapid = Instantiate(bullet, transform.position - new Vector3(2, 0, 0), Quaternion.identity);

        //shotRapid.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed, 0));

        duck = Random.Range(1, 13);
        y_axel = 0;



    }





    void OnCollisionEnter(Collision collision)
    {


        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "ammos")
        {
            health--;
        }


    }

    // Update is called once per frame
    void FixedUpdate()
    {



        if (health == 10)
        {
            Health10.SetActive(true);
            Health9.SetActive(true);
            Health8.SetActive(true);
            Health7.SetActive(true);
            Health6.SetActive(true);
            Health5.SetActive(true);
            Health4.SetActive(true);
            Health3.SetActive(true);
            Health2.SetActive(true);
            Health1.SetActive(true);
        }

        if (health == 9)
        {
            Health10.SetActive(false);
            Health9.SetActive(true);
            Health8.SetActive(true);
            Health7.SetActive(true);
            Health6.SetActive(true);

            Health5.SetActive(true);
            Health4.SetActive(true);
            Health3.SetActive(true);
            Health2.SetActive(true);
            Health1.SetActive(true);

        }

        if (health == 8)
        {
            Health10.SetActive(false);
            Health9.SetActive(false);
            Health8.SetActive(true);
            Health7.SetActive(true);
            Health6.SetActive(true);
            Health5.SetActive(true);
            Health4.SetActive(true);
            Health3.SetActive(true);
            Health2.SetActive(true);
            Health1.SetActive(true);
        }

        if (health == 7)
        {

            Health10.SetActive(false);
            Health9.SetActive(false);
            Health8.SetActive(false);
            Health7.SetActive(true);
            Health6.SetActive(true);
            Health5.SetActive(true);
            Health4.SetActive(true);
            Health3.SetActive(true);
            Health2.SetActive(true);
            Health1.SetActive(true);
        }

        if (health == 6)
        {

            Health10.SetActive(false);
            Health9.SetActive(false);
            Health8.SetActive(false);
            Health7.SetActive(false);
            Health6.SetActive(true);
            Health5.SetActive(true);
            Health4.SetActive(true);
            Health3.SetActive(true);
            Health2.SetActive(true);
            Health1.SetActive(true);

        }

        if (health == 5)
        {
            Health10.SetActive(false);
            Health9.SetActive(false);
            Health8.SetActive(false);
            Health7.SetActive(false);
            Health6.SetActive(false);
            Health5.SetActive(true);
            Health4.SetActive(true);
            Health3.SetActive(true);
            Health2.SetActive(true);
            Health1.SetActive(true);
        }

        if (health == 4)
        {
            Health10.SetActive(false);
            Health9.SetActive(false);
            Health8.SetActive(false);
            Health7.SetActive(false);
            Health6.SetActive(false);

            Health5.SetActive(false);
            Health4.SetActive(true);
            Health3.SetActive(true);
            Health2.SetActive(true);
            Health1.SetActive(true);

        }

        if (health == 3)
        {
            Health10.SetActive(false);
            Health9.SetActive(false);
            Health8.SetActive(false);
            Health7.SetActive(false);
            Health6.SetActive(false);
            Health5.SetActive(false);
            Health4.SetActive(false); ;
            Health3.SetActive(true);
            Health2.SetActive(true);
            Health1.SetActive(true);
        }

        if (health == 2)
        {

            Health10.SetActive(false);
            Health9.SetActive(false);
            Health8.SetActive(false);
            Health7.SetActive(false);
            Health6.SetActive(false);
            Health5.SetActive(false);
            Health4.SetActive(false);
            Health3.SetActive(false);
            Health2.SetActive(true);
            Health1.SetActive(true);
        }

        if (health == 1)
        {

            Health10.SetActive(false);
            Health9.SetActive(false);
            Health8.SetActive(false);
            Health7.SetActive(false);
            Health6.SetActive(false);
            Health5.SetActive(false);
            Health4.SetActive(false);
            Health3.SetActive(false);
            Health2.SetActive(false);
            Health1.SetActive(false);

        }

        if (health == 0)
        {

            Destroy(gameObject);


        }



















        if (ammo > 1)
        {


            if (ammo_Counter == duck)
            {



                if (y_axel == -1)
                {


                    y_axel = 0;
                    print("hello 2 ");


                   ammo_Counter = 0;


                }
                if (y_axel == 0)
                {



                    y_axel = 1;
                    print("hello 1 ");

                   ammo_Counter = 0;

                }






            }

           
            timeLeft -= Time.deltaTime;


            if (timeLeft < 0)
            {

                print(timeLeft);
                print("shoot time");
                GameObject shotRapid = Instantiate(bullet, transform.position - new Vector3(0, y_axel, 0), Quaternion.identity);

                shotRapid.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed, 0));
                //print(duck);

                ammo--;
                ammo_Counter++;

                timeLeft = 10.0f;

            }



        }
        else if (ammo == 1)
        {

            //run reload animation

            //print("reload animation");

        }




    }


}


