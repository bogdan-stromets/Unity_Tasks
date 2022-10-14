using UnityEngine;
using System.Collections;

public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();

        myClass.Add(5, 11);
        myClass.Add("Hello ", "World");
    }
}
