using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour
{
    void Start()
    {
        GenericClass<string> myClass = new GenericClass<string>();
        
        myClass.UpdateItem("World");
    }
}
