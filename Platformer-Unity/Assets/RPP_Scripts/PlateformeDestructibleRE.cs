using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlateformeDestructibleRE : MonoBehaviour
{
    [SerializeField]
    BoxCollider2D boxCollider;

    [SerializeField]
    TilemapRenderer sprite;

    [SerializeField]
    TilemapCollider2D tilemapCollider2D;

    [SerializeField]
    float timeToDestruction = 1.5f;

    [SerializeField]
    float timeToRespawn = 2f;

    private void FixedUpdate()
    {
        OnTriggerEnter2D(boxCollider);
    }

    void OnTriggerEnter2D(Collider2D boxCollider2D)
    {
        if (boxCollider2D.CompareTag("Player"))
        {
            Debug.Log("The player is about to fall");
            StartCoroutine(SelfDestruction(boxCollider, sprite, tilemapCollider2D));
        }
    }

    IEnumerator SelfDestruction(Collider2D collider, TilemapRenderer sprite, TilemapCollider2D tilemapCollider2D)
    {
        yield return new WaitForSeconds(timeToDestruction);
        collider.enabled = false;
        sprite.enabled = false;
        tilemapCollider2D.enabled = false;

        yield return new WaitForSeconds(timeToRespawn);
        collider.enabled = true;
        sprite.enabled = true;
        tilemapCollider2D.enabled = true;
    }
}
