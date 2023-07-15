using System;
using UnityEngine;

public class CompletedHelloWorld : MonoBehaviour
{
    // This is a variable. Variables have three parts to them:
    // Access Modifier: this can be either "public" or "private." public variables are accessible in Unity's inspector, private variables are not
    // Type: every variable needs a type. It can be a value type, like a number, or a reference, like a reference to a component or GameObject 
    // Name: every variable needs a name! You can call them whatever you want, but it's easier to write and read code if your variable names are descriptive
    public string myVariable;

    // Start is a function that is called once at the start of the game
    public void Start()
    {
        // print is a handy function that sends a message to the console
        // It's called "print" in reference to ye olden times before computer monitors, where computers had to physically print all outputs
        // print takes a "string" as an argument, that's what we're putting inside the parenthesis. Strings are a type of data that contains a message. You can create a string by wrapping some text inside quotation marks
        print("Hello, world!");
    }

    // Update is called every frame (60 times a second)
    private void Update()
    {
        // instead of "hard coding" all information into functions, you can pass variables into them!
        print(myVariable);
    }
}
