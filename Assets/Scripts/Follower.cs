using System;
using UnityEngine;

public class Follower : MonoBehaviour
{
    // The gameobject to follow
    public GameObject target;

    // Check these if you want to lock certain axes! For example, locking the Y axis will make it so that the camera will not move up or down
    public bool lockX = false;
    public bool lockY = false;
    public bool lockZ = false;

    private Vector3 offset;

    // Start is called at the start of the game
    private void Start()
    {
        // Get the offset between this game object and the game object that we are following. We'll use this later!
        offset = transform.position - target.transform.position;
    }

    // Update is called every frame, 60 times a second
    private void Update()
    {
        // Get our current position
        Vector3 newPosition = transform.position;

        // If we are not locked on the X axis...
        if (!lockX)
        {
            // ... then update our X position!
            newPosition.x = target.transform.position.x + offset.x;
        }
        // Same thing, with Y
        if (!lockY)
        {
            newPosition.y = target.transform.position.y + offset.y;
        }
        // Same thing, with Z
        if (!lockZ)
        {
            newPosition.z = target.transform.position.z + offset.z;
        }

        // Set our position back so the game updates it!
        transform.position = newPosition;
    }
}
