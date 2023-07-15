using System;
using UnityEngine;

public class CompletedCoinCollector : MonoBehaviour
{
    // A reference to the audio source that plays the pickup sound effect
    public AudioSource audioSource;
    
    // This is a special function that is called whenever a gameobject enters the trigger area of another game object
    private void OnTriggerEnter(Collider other)
    {
        // If the game object that we collided with has the "Coin" tag...
        if (other.gameObject.tag == "Coin")
        {
            // ... then destroy it and play a sound effect!
            Destroy(other.gameObject);
            audioSource.Play();
        }
    }
}