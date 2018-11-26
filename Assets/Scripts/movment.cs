using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour {


    private Rigidbody2D rb;

    public float runSpeed;
    public float jumpForce;




    bool doublejump;
    bool jumping;
    bool grounded;
    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        jumping = false;
        grounded = false;

       


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float jumpAxis = Input.GetAxis("Jump");

        Vector2 movement = new Vector2(horizontal, 0.0f);

        rb.AddForce(movement * runSpeed * Time.deltaTime);



        RaycastHit2D hit = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y - (GetComponent<BoxCollider2D>().bounds.size.y / 2) - 0.1f, 0.0f), Vector2.down);


        if (hit)
        {
            if (hit.distance <= 0.1f)
            {
                grounded = true;
                doublejump = true;
            }
            else
            {
                grounded = false;
            }

        }
        else
        {
            grounded = false;
        }

        if (jumpAxis > 0 && !jumping && grounded)
        {


            jumpStart();
        }
        else if (jumpAxis > 0 && !jumping && doublejump && !grounded)
        {

            Vector3 temp = rb.velocity;

            rb.velocity = new Vector3(temp.x, 0, 0);
            jumpStart();


            doublejump = false;

        }




        else if (jumpAxis == 0)
        {
            jumping = false;

        }





    }

    void jumpStart()
    {
        Vector2 jumpMovement = new Vector2(0, jumpForce);
        jumping = true;
        rb.AddForce(jumpMovement * jumpForce * Time.deltaTime);
    }
    
    
    
    
}
