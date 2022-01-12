using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody2D rb;


    private void Update()
    {
        if (GameManager.instance.isGameRunning)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Jump();
            }
        }
        
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
        GameManager.instance.Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.instance.GameOver();

        }
        
    }

}
