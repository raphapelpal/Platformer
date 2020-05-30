using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAttack : PhysicsObject
{
    private bool attacking = false;

    private float attackTimer = 0;
    private float attacktCd = 0.5f;

    public Collider2D jumpAttackTrigger;

    private Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        jumpAttackTrigger.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("f") && !attacking && !grounded)
        {
            attacking = true;
            attackTimer = attacktCd;
            jumpAttackTrigger.enabled = true;
        }

        if (attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                jumpAttackTrigger.enabled = false;
            }
        }
    }
}
