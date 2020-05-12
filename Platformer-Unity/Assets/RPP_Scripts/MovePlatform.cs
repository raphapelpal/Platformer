using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nextPos;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform platformLocation;

    [SerializeField]
    private Transform transformB;
    


    // Start is called before the first frame update
    void Start()
    {
        posA = platformLocation.localPosition;
        posB = transformB.localPosition;
        nextPos = posB;
    }

    // Update is called once per frame
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
        // if the nextPos id different from posA, change it to equal posA. If it is equal, change it to equal posB
        nextPos = nextPos != posA ? posA: posB;
    }

}
