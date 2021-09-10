using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer sp;

    public float runSpeed = 40;

    private bool gravityNormal = true;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();

    }

    
    public void SetRunSpeed(int SpeedChange) {

        runSpeed = runSpeed + SpeedChange;
    
    }

    public void SetGravityUpward() {
        rb.gravityScale *= -1;
        transform.Rotate(0, 0, 180);
        controller.InvertJumpForce(); // poder saltar cuando estoy en el techo.
        sp.flipX = !sp.flipX; // invierto sprite personaje para mirar en la dirección que camino.
        

    }


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (horizontalMove > 0f || horizontalMove < 0f) {
            anim.SetBool("running", true);
        }
        else
            anim.SetBool("running", false);


        if (Input.GetButtonDown("Jump")) {
            jump = true;
            //ANIM BOOL JUMP
        }

        if (Input.GetButtonDown("Crouch")){
            crouch = true;
        } else if (Input.GetButtonUp("Crouch")){
            crouch = false;
        }

    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }
}
