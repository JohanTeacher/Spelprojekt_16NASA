using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour {


    private Rigidbody2D rb;
    private Animator animator;

    public GameObject gamesss;

    public float runSpeed;
    public float jumpForce;




    bool doublejump;
    bool jumping;
    bool grounded;
    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        jumping = false;
        grounded = false;

       


    }



    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "ammo")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console

            print("hello");
           Destroy(gamesss);

        }

      
    }



    // Update is called once per frame
    void FixedUpdate()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float jumpAxis = Input.GetAxis("Jump");







        Vector2 movement = new Vector2(horizontal, 0.0f);

        transform.position += new Vector3 (horizontal * runSpeed * Time.deltaTime ,0,0 );

        if(movement.x > -0.1f && movement.x < 0.1f)
        {
            animator.SetBool("walking", false);
        }
        else
        {
            animator.SetBool("walking", true);
        }

        if (movement.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }



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
