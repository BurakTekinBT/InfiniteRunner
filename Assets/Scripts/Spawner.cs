using System;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    // A list of platforms to randomly spawn
    public GameObject[] sectionPrefabs;
    // A reference to the player
    public GameObject player;

    // How many platforms ahead we should spawn
    public int numSectionsToKeepAhead = 4;
    // How big each platform is
    public float sectionSize = 20f;
    // How much more big the starting platform is. You only need to set this if the starting area is a different size than a normal platform
    public float extraStartingSectionSize = 0;

    // A private variable (invisible to the Inspector) that keeps track of how many platforms we have spawned so far
    private int numSectionsSpawned = 0;

    // Update is called every single frame, usually 60 times a second!
    private void Update()
    {
        // Do some math to check if we need to spawn in a platform
        float playerDistance = player.transform.position.z;
        int currentPlayerSection = (int)Mathf.Floor((playerDistance - extraStartingSectionSize) / sectionSize);
        if (numSectionsSpawned < currentPlayerSection + numSectionsToKeepAhead)
        {
            // This is a custom function we wrote, below
            SpawnSection();
        }
    }

    // Spawn in a new platform!
    public void SpawnSection()
    {
        numSectionsSpawned += 1;

        GameObject sectionPrefab = sectionPrefabs[Random.Range(0, sectionPrefabs.Length)];
        Vector3 positionToSpawnSection = new Vector3(0, 0, numSectionsSpawned * sectionSize + extraStartingSectionSize);
        Instantiate(sectionPrefab, positionToSpawnSection, Quaternion.identity, transform);
    }
}
