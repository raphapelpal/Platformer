﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : PhysicsObject
{
    private bool attacking = false;

    private float attackTimer = 0;
    private float attacktCd = 0.3f;

    public Collider2D attackTrigger;

    private Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger.enabled = false;
    }

    void Update()
    {
        if(Input.GetKeyDown("f") && !attacking && grounded)
        {
            FindObjectOfType<SoundManagerRPP>().Play("SimpleAttack");
            attacking = true;
            attackTimer = attacktCd;
            attackTrigger.enabled = true;
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
                attackTrigger.enabled = false;
            }
        }
        anim.SetBool("SimpleAttack", attacking);
    }
}
