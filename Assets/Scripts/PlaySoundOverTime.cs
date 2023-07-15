using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOverTime : MonoBehaviour
{
    // This is an example script that we can use to play a sound effect over and over repeatedly
    
    // How often should the sound play?
    public float timeBetweenSound = 0.25f;
    public float timeOffset = 0f;

    // How much should we randomize the volume and pitch each time we play the sound?
    public float randomVolume = 0.1f;
    public float randomPitch = 0.1f;

    // These are private variables! They are not visible in the Unity Inspector, and are managed exclusively by code.
    // How much time we have until we play the sound effect
    private float timeUntilPlaySoundEffect;
    // A reference to the audio source that has the sound effect
    private AudioSource audioSource;
    // The original volume and pitch of the audio source. We'll randomize this a little bit with randomVolume and randomPitch
    private float originalVolume;
    private float originalPitch;

    // Start is called once at the start of the game
    void Start()
    {
        // Get the attached audio source (this is an alternative to making it public)
        audioSource = GetComponent<AudioSource>();
        
        timeUntilPlaySoundEffect = timeOffset;
        originalVolume = audioSource.volume;
        originalPitch = audioSource.pitch;
    }

    // Update is called once per frame, 60 frames a second
    void Update()
    {
        // Decrease the time we need
        timeUntilPlaySoundEffect -= Time.deltaTime;

        // If enough time has passed that we should play a sound effect...
        if (timeUntilPlaySoundEffect <= 0)
        {
            // Then play the sound!
            
            // Reset the timeUntilPlaySoundEffect
            timeUntilPlaySoundEffect += timeBetweenSound;

            // Randomize the volume and pitch a little
            audioSource.volume = originalVolume + Random.Range(-randomVolume, randomVolume);
            audioSource.pitch = originalPitch + Random.Range(-randomPitch, randomPitch);
            
            // Lastly, play the sound!
            audioSource.Play();
        }
    }
}
