using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    [SerializeField] EnemyDamage enemy1, enemy2, enemy3;

    public void RespawnEnemies()
    {
        Debug.Log("Respawned Enemies");
        enemy1.EnemyRespawn();
        enemy2.EnemyRespawn();
        enemy3.EnemyRespawn();
    }
}
