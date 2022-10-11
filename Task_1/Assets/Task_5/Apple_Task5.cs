using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple_Task5 : Fruit_Task5
{ 
    public Apple_Task5()
    {
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }
    public Apple_Task5(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");
    }
}
