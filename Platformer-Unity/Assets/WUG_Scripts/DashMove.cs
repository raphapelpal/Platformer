using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : PlayerController
{
    public float dashSpeed;
    public float startDashTime;
    public TrailRenderer trailRenderer;

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
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                direction = 1;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                direction = 2;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                direction = 3;
            }
        }
        else
        {
            if(dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }
            else
            {

                dashTime -= Time.deltaTime;
                animator.SetTrigger("Dash");
            }
            if(direction == 1)
            {
                rb.velocity = Vector2.left * dashSpeed;
            }
            else if(direction == 2)
            {
                rb.velocity = Vector2.right * dashSpeed;
            }
            else if (direction == 3)
            {
                rb.velocity = Vector2.up * dashSpeed;
            }
        }
    }
}
