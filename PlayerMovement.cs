using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    float horizontalmove = 0f;
    public float runspeed = 40f;
    bool jump = false;
    bool crouch = false;
    void Update()
    {
        
        horizontalmove = Input.GetAxisRaw("Horizontal") * runspeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalmove));
        if(Input.GetButtonDown("Jump")){
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        if(Input.GetButtonDown("crouch")){
            crouch = true;
        
        }
        else if(Input.GetButtonUp("crouch")){
            crouch = false;
        }
    }
    public void onLanding(){
        animator.SetBool("IsJumping", false);
        jump = false;
    }

    public void onCrouching(bool isCrouching){
         animator.SetBool("IsCrouching", isCrouching);
    }
    void FixedUpdate()
     {
        controller.Move(horizontalmove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
