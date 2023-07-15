using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOverTime : MonoBehaviour
{
    // Creating a variable that represents how fast this object rotates (and in what direction)
    // "new Vector3(0, 1, 0)" is the default value
    public Vector3 rotationsPerSecond = new Vector3(0, 1, 0);
    
    // Update is called once per frame
    void Update()
    {
        // Spin spin spin spin spin spin spin!
        transform.Rotate(rotationsPerSecond * Time.deltaTime * 360);
    }
}
