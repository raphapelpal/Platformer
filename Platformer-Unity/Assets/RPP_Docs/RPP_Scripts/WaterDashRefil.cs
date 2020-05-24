using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDashRefil : MonoBehaviour
{
    public DashBar dashBar;
    [SerializeField] CompositeCollider2D compositeCollider;

    private void Start()
    {
        dashBar = GetComponent<DashBar>();
    }

    private void Update()
    {
        OnTriggerEnter2D(compositeCollider);
    }

    void OnTriggerEnter2D(Collider2D boxCollider2D)
    {
        if (boxCollider2D.CompareTag("Player"))
        {
            dashBar.DashRefil();
        }
    }
}
