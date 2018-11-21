using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiddentrigger : MonoBehaviour {


    int kaka;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}





    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {

            ;

        }


    }


    int Ones(int x){


        if (x == 1)
        {




            kaka = 1;

        }


        return kaka;


    }



}
