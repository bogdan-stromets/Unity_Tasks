using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ColorScript : MonoBehaviour
{
    void Start()
    {
        renderer.sharedMaterial.color = Color.red;
    }
}
