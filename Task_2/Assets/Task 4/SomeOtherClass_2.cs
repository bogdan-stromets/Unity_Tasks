using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass_2 : MonoBehaviour
{
    void Start()
    {
        SomeClass_2 myClass = new SomeClass_2();

        myClass.GenericMethod<string>("Hello");
    }
}
