using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : GemCollision 
{

    public int speed;
    public FloatingJoystick joystick;
    Rigidbody rb;
    public Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        CharacterControl();
    }

    public void CharacterControl()
    {
         Vector3 direction = Vector3.forward * joystick.Vertical + Vector3.right * joystick.Horizontal;
         rb.velocity = direction * speed * Time.deltaTime;

        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }

}
