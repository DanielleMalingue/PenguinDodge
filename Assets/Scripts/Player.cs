using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
public float moveSpeed;
Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   void Update()
{
    // Get the acceleration vector
    Vector3 acceleration = Input.acceleration;

    // Check the x component of the acceleration vector
    if (acceleration.x > 0)
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y); // Move right
    }
    else if (acceleration.x < 0)
    {
        rb.velocity = new Vector2(-moveSpeed, rb.velocity.y); // Move left
    }
    else
    {
        rb.velocity = new Vector2(0, rb.velocity.y); // Stop horizontal movement
    }
}

private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.tag == "Block")
    {
        SceneManager.LoadScene("WelcomeScene");
    }
}
}
