using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBrasiers : MonoBehaviour
{
    [SerializeField]
    GameObject brazier;
    [SerializeField]
    BoxCollider2D boxCollider;

    private void Start()
    {
        brazier.SetActive(false);
    }

    private void Update()
    {
        OnTriggerEnter2D(boxCollider);
    }

    void OnTriggerEnter2D(Collider2D boxCollider)
    {
        if (boxCollider.CompareTag("Player"))
        {
            brazier.SetActive(true);
        }
    }

}
