using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    [SerializeField]
    private Transform playerPosition;

    void Start()
    {
        transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y, playerPosition.position.z);
    }
    public void ChangeRespawnPosition()
    {
        transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y, playerPosition.position.z);
    }

}
