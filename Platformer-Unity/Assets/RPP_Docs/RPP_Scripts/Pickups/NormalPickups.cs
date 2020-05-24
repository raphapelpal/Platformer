using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalPickups : MonoBehaviour
{
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
            Debug.Log("Has touched the player");

            pickupObject.SetActive(false);
        }
    }

}
