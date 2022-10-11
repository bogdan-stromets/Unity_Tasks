using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad_Task5 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Creating the fruit");
        Fruit_Task5 myFruit = new Fruit_Task5();
        Debug.Log("Creating the apple");
        Apple_Task5 myApple = new Apple_Task5();

       
        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();


        Debug.Log("Creating the fruit");
        myFruit = new Fruit_Task5("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple_Task5("green");


        myFruit.SayHello();
        myFruit.Chop();


        myApple.SayHello();
        myApple.Chop();
    }
}
