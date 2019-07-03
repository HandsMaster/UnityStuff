using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public string petName;
    public string petOwner;
    public Cat()
    {
        numOfLegs = 4;
        numOfHeads = 1;
        numOfEyes = 2;
        hasFur = true;
        isAlive = true;
        age = 1;
        hasHooves = false;
        colors = new Color[1] { Color.black };
    }
}
