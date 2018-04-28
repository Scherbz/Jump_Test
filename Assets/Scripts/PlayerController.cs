using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Animator animator;
    [SerializeField] private float maxSpeed = 10f;
    [SerializeField] private float maxForce = 1f;

    public bool jump;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        animator.SetFloat("runSpeed", GetComponent<Rigidbody2D>().velocity.x);

        if(jump)
        {
            animator.SetFloat("jumpForce", GetComponent<Rigidbody2D>().velocity.y);
            jump = false;
        }
    }

    public void Move(float move) //, bool jump)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }

    public void Jump(float move, float jumpForce) //, bool jump)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, jumpForce); // * maxForce);
        jump = false;
    }

    //// Use this for initialization
    //void Start ()
    //   {

    //}

    //// Update is called once per frame
    //void Update ()
    //   {

    //}
}
