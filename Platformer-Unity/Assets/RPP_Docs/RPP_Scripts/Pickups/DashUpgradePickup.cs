using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashUpgradePickup : MonoBehaviour
{
     [SerializeField]
    private GameObject pickupObject;
    [SerializeField]
    private BoxCollider2D boxCollider;
    [SerializeField]
    DashBar dashBar;

    private void FixedUpdate()
    {
        OnTriggerEnter2D(boxCollider);
    }


    void OnTriggerEnter2D(Collider2D boxCollider2D)
    {
        if (boxCollider2D.CompareTag("Player"))
        {
            Debug.Log("has collected an upgrade");
            dashBar.AddMaxDash();
            pickupObject.SetActive(false);
        }
    }

}
