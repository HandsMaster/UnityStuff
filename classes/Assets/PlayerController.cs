using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newVel = new Vector2(0, 0);

        if (Input.GetKey("a"))
        {
            // Left
            newVel.x = -speed;
        }

        if (Input.GetKey("d"))
        {
            // Right
            newVel.x = speed;
        }

        if (Input.GetKey("w"))
        {
            // Up
            newVel.y = speed;
        }

        if (Input.GetKey("s"))
        {
            // Down
            newVel.y = -speed;
        }

        if (newVel.x != 0 || newVel.y != 0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(newVel.x, newVel.y, 0);
        }
    }
}
