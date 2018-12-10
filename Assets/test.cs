using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{



    public GameObject bullet;
    public int Speed = 32000;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        GameObject shotRapid = Instantiate(bullet, transform.position - new Vector3(2, 0, 0), Quaternion.identity);

        shotRapid.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Speed, 0));

    }
}