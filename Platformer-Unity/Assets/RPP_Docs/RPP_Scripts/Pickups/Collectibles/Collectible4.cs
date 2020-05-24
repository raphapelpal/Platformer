using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible4 : MonoBehaviour
{
    [SerializeField]
    GameObject pickupObject;
    [SerializeField]
    BoxCollider2D boxCollider;
    public DashCollectibles dashCollectibles;

    private void FixedUpdate()
    {
        OnTriggerEnter2D(boxCollider);
    }


    void OnTriggerEnter2D(Collider2D boxCollider2D)
    {
        if (boxCollider2D.CompareTag("Player"))
        {
            Debug.Log("Has picked a collectible");
            dashCollectibles.TookCol4();
            pickupObject.SetActive(false);
        }
    }
}
