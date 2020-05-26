using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    [SerializeField] GameObject enemy1, enemy2, enemy3;

    public void RespawnEnemies()
    {
        enemy1.SetActive(true);
        enemy2.SetActive(true);
        enemy3.SetActive(true);
    }
}
