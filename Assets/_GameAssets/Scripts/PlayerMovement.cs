using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float movementSpeed;
    [SerializeField] private float airControl = 0.7f;
    private Rigidbody2D rb;

    [Header("Jump Settings")]
    [SerializeField] private KeyCode jumpKey;
    [SerializeField] private float jumpForce;

    [Header("Ground Check Settings")]
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float raycastDistance = 0.2f;
    private bool isGround;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        applyMovement();
    }

    private void applyMovement()
    {
        isGround = Physics2D.Raycast(groundCheck.position, Vector2.down, raycastDistance, groundLayer);

        float horizontal = Input.GetAxis("Horizontal");

        if (isGround)
        {
            rb.velocity = new Vector2(horizontal * movementSpeed, rb.velocity.y);
        }
        else if (!isGround)
        {
            rb.velocity = new Vector2(horizontal * movementSpeed * airControl, rb.velocity.y);
        }

        if (Input.GetKey(jumpKey) && isGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }

        
    }
}
