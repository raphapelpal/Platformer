using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : PlayerController
{
    public float dashSpeed;
    public float startDashTime;

    private Rigidbody2D rb;
    private float dashTime;
    private int direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && !grounded)
            {
                direction = 1;
                animator.SetTrigger("Dash");
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && !grounded)
            {
                direction = 2;
                animator.SetTrigger("Dash");
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) && !grounded)
            {
                direction = 3;
                animator.SetTrigger("Dash Up");
            }
            else if (Input.GetKeyDown(KeyCode.E) && !grounded)
            {
                direction = 4;
                animator.SetTrigger("Dash Diagonale");
            }
            else if (Input.GetKeyDown(KeyCode.A) && !grounded)
            {
                direction = 5;
                animator.SetTrigger("Dash Diagonale");
            }
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;
            }
            if (direction == 1)
            {
                rb.velocity = Vector2.left * dashSpeed;
            }
            else if (direction == 2)
            {
                rb.velocity = Vector2.right * dashSpeed;
            }
            else if (direction == 3)
            {
                rb.velocity = Vector2.up * dashSpeed;
            }
            else if (direction == 4)
            {
                rb.velocity = new Vector2(0.5f, 0.5f) * dashSpeed;
            }
            else if (direction == 5)
            {
                rb.velocity = new Vector2(-0.5f, 0.5f) * dashSpeed;
            }
        }
    }
}
