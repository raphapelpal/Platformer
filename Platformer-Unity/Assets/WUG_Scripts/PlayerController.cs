using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject
{
    public bool moveInAir;
    public float fireRate;
    public float maxSpeed = 12;
    public float jumpTakeOffSpeed = 18;
    public Collider2D[] attackHitBoxes;

    private float nextFire;
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

        // Attack en saut
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && !grounded)
        {
            velocity.y = -jumpTakeOffSpeed;
            maxSpeed = 50f;
            move.x = 1f;
            animator.SetTrigger("JumpAttack");
        }

        targetVelocity = move * maxSpeed;
        Debug.Log(targetVelocity);

        if (Input.GetKeyDown(KeyCode.G) && Time.time > nextFire)
        {
            LaunchAttack(attackHitBoxes[0]);
            nextFire = Time.time + fireRate;
        }

        // Les animations
        animator.SetBool("grounded", grounded);
        animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);
        animator.SetFloat("velocityY", Mathf.Abs(velocity.y));

        targetVelocity = move * maxSpeed;
    }

    void LaunchAttack(Collider2D col)
    {
        Collider2D collider = Physics2D.OverlapBox(col.bounds.center, col.bounds.extents, col.transform.rotation.y, LayerMask.GetMask("HitBox"));
        if (collider != null)
        {
            if (collider.transform.root != transform)
            {
                float damage = 0f;
                switch (col.name)
                {
                    case "BasicAttack":
                        damage = 10f;
                        break;
                    default:
                        Debug.Log("Unable to identify attack");
                        break;
                }
                Debug.Log(collider.transform.root.name + " takes " + damage + " Damage.");
                collider.SendMessageUpwards("TakeDamage", damage);
            }
        }
    }

    private void ResetMaxSpeed()
    {
        maxSpeed = 12f;
    }
}
