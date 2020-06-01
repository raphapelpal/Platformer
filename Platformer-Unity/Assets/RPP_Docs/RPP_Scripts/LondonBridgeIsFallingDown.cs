using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LondonBridgeIsFallingDown : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] BoxCollider2D boxCollider;

    private void Start()
    {
        animator.enabled = false;
    }

    private void Update()
    {
        OnTriggerEnter2D(boxCollider);
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            animator.enabled = true;
        }
    }
}
