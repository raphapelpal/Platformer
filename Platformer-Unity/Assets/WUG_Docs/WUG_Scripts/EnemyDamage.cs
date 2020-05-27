using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float maxHealth = 20;
    public float curHealth = 20;
    public float damage = 20;
    public DashBar dashBar;
    private void Start()
    {
        curHealth = maxHealth;
    }
    private void Update()
    {
        if (curHealth <= 0)
        {
            gameObject.SetActive(false);
            dashBar.DashRefil();
        }
    }
    public void Damage(int Damage)
    {
        curHealth -= damage;
    }
}
