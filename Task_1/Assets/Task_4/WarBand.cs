using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy_Task4();
        Humanoid orc = new Orc();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
