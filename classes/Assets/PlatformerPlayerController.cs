using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerPlayerController : MonoBehaviour
{
    public float speed = 1;
    bool onGround = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newVel = new Vector2(0, GetComponent<Rigidbody>().velocity.y);

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

        if (Input.GetKey("w") && onGround == true)
        {
            // Up
            newVel.y = speed;
        }

        if (newVel.x != 0 || newVel.y != 0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(newVel.x, newVel.y, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }
}
