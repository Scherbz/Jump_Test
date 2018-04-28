using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : PlayerController {

    private PlayerController character;
    private float jumpForce = 15;
    private float runSpeed = 0.5f;
    private bool grounCheck = false;

    private void Awake()
    {
        character = GetComponent<PlayerController>();
    }

    private void FixedUpdate()
    {
        character.Move(runSpeed); //, jump);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(grounCheck)
            {
                jump = true;
                character.Jump(runSpeed, jumpForce);
            }
            else
            {
                jump = false;
            }
            
            //Rigidbody2D myRB2D = GetComponent<Rigidbody2D>(); //create the rigidbody object to later add horizontal/vertical movement

            //myRB2D.velocity = new Vector2(0, 0); //first 0 is horizontal and second 0 is vertical
            //myRB2D.AddForce(new Vector2(0, 300)); //Adds an upward force
        }
    }

    //// Use this for initialization
    //void Start ()
    //   {

    //}

    // Update is called once per frame
    void Update()
    {

    }
}
