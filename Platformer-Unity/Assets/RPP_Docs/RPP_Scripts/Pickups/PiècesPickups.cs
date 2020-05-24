using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiècesPickups : MonoBehaviour
{
    [SerializeField]
    Score score;
    [SerializeField]
    private GameObject pickupObject;
    [SerializeField]
    private BoxCollider2D boxCollider;

    private void FixedUpdate()
    {
        OnTriggerEnter2D(boxCollider);
    }

    void OnTriggerEnter2D(Collider2D boxCollider2D)
    {
        if (boxCollider2D.CompareTag("Player"))
        {
            Debug.Log("The player has picked a coin");
            score.AddCoin();
            pickupObject.SetActive(false);
        }
    }
}
