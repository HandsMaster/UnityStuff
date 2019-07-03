using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doge : Animal
{
    public string petName;
    public string petOwner;
    public Doge()
    {
        numOfLegs = 4;
        numOfHeads = 1;
        numOfEyes = 2;
        hasFur = true;
        isAlive = true;
        age = 1;
        hasHooves = false;
        colors = new Color[1]{new Color(99 / 255f, 57 / 255f, 57 / 255f) };
    }
}
