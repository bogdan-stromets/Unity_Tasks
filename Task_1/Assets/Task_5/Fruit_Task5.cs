using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit_Task5
{
    public string color;
    public Fruit_Task5()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    public Fruit_Task5(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
