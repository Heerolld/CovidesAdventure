using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 movementInput;
    Rigidbody2D rb;
    public float moveSpeed = 5f; // Adjust this value to control the movement speed

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        // Calculate movement direction based on input
        Vector2 movementDirection = movementInput.normalized;

        // Calculate movement amount based on direction and speed
        Vector2 movementAmount = movementDirection * moveSpeed * Time.fixedDeltaTime;

        // Move the rigidbody
        rb.MovePosition(rb.position + movementAmount);
    }

    // Called when movement input is received
    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }
}
