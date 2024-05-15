using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpForce = 10f; // The force to apply for jumping

    void Start()
    {
        // Get the reference to the Rigidbody2D component
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Add a vertical force to the Rigidbody2D component
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
        }
    }
}
