using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int numOfLegs;
    public int age;
    public int numOfEyes;
    public int numOfHeads;
    public float height;
    public float weight;
    public bool isAlive;
    public bool hasFur;
    public bool hasHooves;
    public Color[] colors;

    public void Move(Vector2 destination)
    {
       // move to a place
    }

    public void Die()
    {
        // Die x_x
    }

    void Update()
    {
        if (colors.Length > 0)
        {
            GetComponent<MeshRenderer>().material.color = colors[0];
        }
    }
}
