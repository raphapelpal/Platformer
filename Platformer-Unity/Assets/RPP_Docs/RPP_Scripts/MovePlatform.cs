using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nextPos;

    [SerializeField] float speed;

    //[SerializeField] GameObject platformObject;

    [SerializeField] Transform platformLocation;

    [SerializeField] Transform destination;

    [SerializeField] Rigidbody2D azaèsRigidbody;
    [SerializeField] Transform azaèsTransform;

    //[SerializeField] CompositeCollider2D platformCollider;
    
    void Start()
    {
        posA = platformLocation.localPosition;
        posB = destination.localPosition;
        nextPos = posB;
        
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        platformLocation.localPosition = Vector3.MoveTowards(platformLocation.localPosition, nextPos, speed * Time.deltaTime);

        if(Vector3.Distance(platformLocation.localPosition, nextPos) <= 0.1)
        {
            ChangeDestination();
        }
    }

    private void ChangeDestination()
    {
        // if the nextPos is different from posA, change it to equal posA. If it is equal, change it to equal posB
        nextPos = nextPos != posA ? posA: posB;
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            azaèsRigidbody.bodyType = RigidbodyType2D.Kinematic;
            Debug.Log("Has transformed the Rigidbody");
            //azaèsTransform.localPosition = Vector2.MoveTowards(azaèsTransform.localPosition, platformLocation.localPosition, Time.deltaTime);
        }
    }*/

}
