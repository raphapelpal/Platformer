using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveRigidbody : MonoBehaviour
{
    [SerializeField] Vector2 v2Force;

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity += v2Force;
    }
}
