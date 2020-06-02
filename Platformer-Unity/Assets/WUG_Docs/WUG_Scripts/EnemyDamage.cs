using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float maxHealth = 20;
    public float curHealth = 20;
    public float damage = 20;
    public SpriteRenderer enemySprite;
    //public MeshRenderer enemyRenderer;
    public CircleCollider2D enemyCircleCollider2D;
    public DashBar dashBar;
    private bool canRefilDash;
    private void Start()
    {
        canRefilDash = true;
        curHealth = maxHealth;
    }
    private void Update()
    {
        if (curHealth <= 0 && canRefilDash == true)
        {
            EnemyIsDead();
            canRefilDash = false;
        }
    }
    public void Damage(int Damage)
    {
        curHealth -= damage;
    }

    private void EnemyIsDead()
    {
        enemySprite.enabled = false;
        enemyCircleCollider2D.enabled = false;
        dashBar.DashRefil();
    }

    public void EnemyRespawn()
    {
        curHealth = maxHealth;
        enemySprite.enabled = true;
        enemyCircleCollider2D.enabled = true;
        canRefilDash = true;
    }
}
