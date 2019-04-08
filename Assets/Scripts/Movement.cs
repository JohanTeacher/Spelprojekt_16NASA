using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


    private Rigidbody2D rb;

    public GameObject gamesss;

    public float runSpeed;
    public float jumpForce;

    Animator animator;
    SpriteRenderer spriteRenderer;




    bool doublejump;
    bool jumping;
    bool grounded;
    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); 
        spriteRenderer = GetComponent<SpriteRenderer>();

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

        if (movement.x > 0.1f)
        {
            //går höger

            //vänd år höger
            spriteRenderer.flipX = false;

            //starta animationen
            animator.SetBool("walking", true);

        }
        else if (movement.x < -0.1f)
        {
            //går vänster

            //vönd
            spriteRenderer.flipX = true;

            //animation
            animator.SetBool("walking", true);

        }
        else 
        {
            //stannar
            //stäng av animation
            animator.SetBool("walking", false);
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
