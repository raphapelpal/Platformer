using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTimerBonus : MonoBehaviour
{
    public Timer timer;
    public GameObject gameObject;
    public BoxCollider2D boxCollider2D;

    private void FixedUpdate()
    {
        OnTriggerEnter2D(boxCollider2D);
    }

    void OnTriggerEnter2D(Collider2D boxCollider2D)
    { 
        if (boxCollider2D.CompareTag("Player"))
        {
            timer.AddTime();
            gameObject.SetActive(false);
        }
    }
}
