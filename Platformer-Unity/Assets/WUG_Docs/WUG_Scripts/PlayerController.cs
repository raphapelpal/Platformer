using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject
{
    public float maxSpeed = 14f;
    public float jumpTakeOffSpeed = 18f;

    private bool facingRight;
    private SpriteRenderer spriteRenderer;
    protected Animator animator;

    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer> ();
        animator = GetComponent<Animator>();
        facingRight = true;
    }

    private void flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            Quaternion rotation = transform.rotation;
            rotation.y = 180 * (facingRight ? 0 : 1);
            transform.rotation = rotation;
        }
    }

    protected override void ComputeVelocity ()
    {
        // Mouvement du personnage
        maxSpeed = 12f;
        Vector2 move = Vector2.zero;
        move.x = Input.GetAxis("Horizontal");
        flip(move.x);

        // Le saut
        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = jumpTakeOffSpeed;
            animator.SetTrigger("Jump");
        }
        else if (Input.GetButtonUp("Jump"))
        {
            if (velocity.y > 0)
                velocity.y = velocity.y * 0.5f;
        }

        // Attack en saut
        if (Input.GetKeyDown("f") && !grounded)
        {
            velocity.y = -jumpTakeOffSpeed;
            maxSpeed = 50f;
            move.x = 0f;
            animator.SetTrigger("JumpAttack");
        }

        // Le sprint
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 28f;
            animator.SetBool("Sprint", true);
        }
        
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("Sprint", false);
        }

        targetVelocity = move * maxSpeed;
       // Debug.Log(targetVelocity);

        // Test Death
        /*if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("Dead");
        }*/

        // Les animations
        animator.SetBool("grounded", grounded);
        animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);
        animator.SetFloat("velocityY", Mathf.Abs(velocity.y));

        targetVelocity = move * maxSpeed;
    }

    private void ResetMaxSpeed()
    {
        maxSpeed = 12f;
    }
}
