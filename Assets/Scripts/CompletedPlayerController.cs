using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedPlayerController : MonoBehaviour
{
    // These are variables that are accessible to the inspector
    
    // forwardSpeed is how fast the player is moving forward
    public float forwardSpeed = 5;
    
    // horizontalSpeed is how fast the player can move side-to-side
    public float horizontalSpeed = 5;
    
    // addSpeedOverTime is how much speed is added to forwardSpeed every second
    public float addSpeedOverTime = 0.05f;
    
    // body is a reference to the Rigidbody component that is attached to the same GameObject that our PlayerController is attached to
    // We can use this reference to modify properties of the Rigidbody, like velocity
    public Rigidbody body;

    // Update is called once every frame
    public void Update()
    {
        forwardSpeed += addSpeedOverTime * Time.deltaTime;

        Vector3 velocity = body.velocity;
        velocity.x = 0;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x = -horizontalSpeed;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x = horizontalSpeed;
        }

        velocity.z = forwardSpeed;

        body.velocity = velocity;
    }
}
