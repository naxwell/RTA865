using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ECM.Common;
using ECM.Controllers;


public sealed class MyCharacterController : BaseCharacterController
{
    public Animator playerCamera;
    public Animator charAnim;



    protected override void Animate()
    {
        // Add animator related code here...
    }
    protected override void HandleInput()
    {
        // Handle your custom input here...
        moveDirection = new Vector3
        {
            x = Input.GetAxisRaw("Horizontal"),
            y = 0.0f,
            z = Input.GetAxisRaw("Vertical")
        };

        //walk = Input.GetButton("Fire3");
        jump = Input.GetButton("Jump");

        // Transform moveDirection vector to be relative to camera view direction
        //moveDirection = moveDirection.relativeTo(playerCamera);
    }

    protected override void Move()
    {

        // Apply movement

        // If using root motion and root motion is being applied (eg: grounded),
        // move without acceleration / deceleration, let the animation takes full control

        var desiredVelocity = CalcDesiredVelocity();

        if (useRootMotion && applyRootMotion)
        {
            movement.Move(desiredVelocity, speed, !allowVerticalMovement);
            playerCamera.SetBool("isDrunk", true);
        }
        else
        {
            // Move with acceleration and friction

            var currentFriction = isGrounded ? groundFriction : airFriction;
            var currentBrakingFriction = useBrakingFriction ? brakingFriction : currentFriction;

            movement.Move(desiredVelocity, speed, acceleration, deceleration, currentFriction,
                currentBrakingFriction, !allowVerticalMovement);

            animator.SetBool("isDrunk", true);

        }

    }
}

