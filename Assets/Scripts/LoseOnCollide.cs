using System;
using UnityEngine;

public class LoseOnCollide : MonoBehaviour
{
    // A reference to a game object that we will enable when we lose (for instance, we might want to enable a lose screen)
    public GameObject enableOnLose;
    
    // This is a special function that is called when we touch another collider
    public void OnCollisionEnter(Collision collision)
    {
        // If the game object that we are colliding with has the "Wall" tag...
        if (collision.gameObject.tag == "Wall")
        {
            // ... then pause the game (Time.timeScale = 0;) and enable the lose screen!
            Time.timeScale = 0;
            enableOnLose.SetActive(true);
        }
    }
}
