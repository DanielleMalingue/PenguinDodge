using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinMoveVertical : MonoBehaviour
{
    public float movementSpeed = 5.0f; // Adjust movement speed as needed
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Read accelerometer input
        float verticalAcceleration = Input.acceleration.y;

        // Apply vertical movement based on accelerometer input
        Vector2 movement = new Vector2(0f, verticalAcceleration);
        rb.velocity = movement * movementSpeed;
    }
}
