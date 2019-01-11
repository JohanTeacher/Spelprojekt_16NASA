using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    float timer =  0;
    public float timeBetweenShots = 3.0f; 

    public GameObject bullet;
    public int Speed = 32000;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if(timer >= timeBetweenShots)
        {
            GameObject shotRapid = Instantiate(bullet, transform.position - new Vector3(2, 0, 0), Quaternion.identity);

            shotRapid.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed, 0));

            timer = 0;
        }


    }
}