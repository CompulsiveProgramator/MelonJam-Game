using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_Movement : MonoBehaviour
{
    public float jumpForce;
    public float climbSpeed; //To select climbing speed of the cat
    public float Speed; //To select movement speed of the cat
    private float Horizontal; //To know if the player presses "A" or "D"
    private float Vertical; //To know if the player presses "W" or "S"
    private Rigidbody2D Rigidbody2D;
    private CapsuleCollider2D capsuleCollider2D;
    private bool Grounded; //To know if the cat is in the ground
    private bool climbing; //To know if the cat is climbing stairs or not
    private float initialGravity; //To store the initial gravity
    private Vector3 originalScale; //The "x" and "y" original scale

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
        initialGravity = Rigidbody2D.gravityScale;
        originalScale = transform.localScale;
    }

    /*
        Method called "every frame" once
    */
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        if (Horizontal < 0.0f) transform.localScale = originalScale;
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);

        if(Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            Grounded = true;
        }
        else
        {
            Grounded = false;
        }

        if (Input.GetKeyDown(KeyCode.W) && Grounded == true)
        {
            Jump();
        }
    }

    /*
        Method used for the cat jumping
    */
    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * jumpForce);
    }

    private void FixedUpdate() {
        Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);
        Climb();
    }

    /*
        Method called to climb the stairs
    */
    private void Climb()
    {
        if((Vertical != 0 || climbing == true) && (capsuleCollider2D.IsTouchingLayers(LayerMask.GetMask("Stairs"))))
        {
            Vector2 newVelocity = new Vector2(Rigidbody2D.velocity.x, Vertical * climbSpeed);
            Rigidbody2D.velocity = newVelocity;
            Rigidbody2D.gravityScale = 0;
            climbing = true;
        }else
        {
            Rigidbody2D.gravityScale = initialGravity; 
            climbing = false;
        }

        if(Grounded)
        {
            climbing = false;
        }
    }
}
