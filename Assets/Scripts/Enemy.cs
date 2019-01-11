using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class Enemy : MonoBehaviour
{


    public GameObject bullet;   //the bullet we are shooting must have a rigidbody
    public int Speed = 32000; //the speed the bullet is shot at

  public int ammo = 10;
    public int ammo_Counter;


    public int y_axel;
     public int duck;


    //this is only used if rapid fire is set to true
    //RateOfFire privat

    Rigidbody enemyRigB;

    // Use this for initialization
    void Start()
    {
        enemyRigB = GetComponent<Rigidbody>();

        GameObject shotRapid = Instantiate(bullet, transform.position - new Vector3(2, 0, 0), Quaternion.identity);

        shotRapid.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed, 0));

        duck = Random.Range(1, 13);
        y_axel = 0;



}







    // Update is called once per frame
    void FixedUpdate()
    {
        if(ammo > 1){


            if (ammo_Counter == duck){



                if (y_axel == -1){


                    y_axel = 0;
                    print("hello 2 ");


                }
                if (y_axel == 0){



                    y_axel = 1;
                    print("hello 1 ");



                }
                





            }

            GameObject shotRapid = Instantiate(bullet, transform.position - new Vector3(0, y_axel, 0), Quaternion.identity);

            shotRapid.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed, 0));
            print(duck);

            ammo --;
            ammo_Counter++;






        }
        else if (ammo == 1)
        {

            //run reload animation

            print("reload animation");

        }




    }

}
