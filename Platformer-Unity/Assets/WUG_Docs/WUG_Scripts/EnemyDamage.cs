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
    public GameObject enemyParticle;
    public DashBar dashBar;
    private bool canRefilDash;
    private void Start()
    {
        canRefilDash = true;
        curHealth = maxHealth;
    }
    private void Update()
    {
        OnTriggerEnter2D(enemyCircleCollider2D);

        if (curHealth <= 0 && canRefilDash == true)
        {
            EnemyIsDead();
            canRefilDash = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spear"))
        {
            curHealth = 0;
        }
    }

    private void EnemyIsDead()
    {
        enemySprite.enabled = false;
        enemyCircleCollider2D.enabled = false;
        enemyParticle.SetActive(false);
        dashBar.DashRefil();
    }

    public void EnemyRespawn()
    {
        curHealth = maxHealth;
        enemySprite.enabled = true;
        enemyCircleCollider2D.enabled = true;
        enemyParticle.SetActive(true);
        canRefilDash = true;
    }
}
