using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformeDestructibleRE : MonoBehaviour
{
    [SerializeField] BoxCollider2D boxCollider;
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] Animator animator;

    [SerializeField] float timeToDestruction = 1.5f;
    [SerializeField] float timeToRespawn = 2f;

    private void Start()
    {
        animator.enabled = false;
    }

    private void FixedUpdate()
    {
        OnTriggerEnter2D(boxCollider);
    }

    void OnTriggerEnter2D(Collider2D boxCollider2D)
    {
        if (boxCollider2D.CompareTag("Player"))
        {
            Debug.Log("The player is about to fall");
            StartCoroutine(SelfDestruction(boxCollider, sprite, animator));
        }
    }

    IEnumerator SelfDestruction(Collider2D collider, SpriteRenderer sprite, Animator animator)
    {
        animator.enabled = true;
        yield return new WaitForSeconds(timeToDestruction);
        collider.enabled = false;
        sprite.enabled = false;

        animator.enabled = false;
        yield return new WaitForSeconds(timeToRespawn);
        collider.enabled = true;
        sprite.enabled = true;
    }
}
