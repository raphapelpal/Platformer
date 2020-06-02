
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnAzaès : MonoBehaviour
{
    [SerializeField]
    private Transform lastCheckpoint;

    [SerializeField]
    private SpriteRenderer playerSprite;

    public Systems systems;
    public Camera_Follow camera_Follow;


    public void BackToCheckpoint()
    {
        StartCoroutine(BeforeRespawn(lastCheckpoint));
        Debug.Log("BeforeRespawn has been called");
    }


    IEnumerator BeforeRespawn(Transform lastCheckpoint)
    {
        playerSprite.enabled = false;
        camera_Follow.enabled = false;

        yield return new WaitForSeconds(0.2f);

        systems.FullHealth();

        transform.position = new Vector3(lastCheckpoint.position.x, lastCheckpoint.position.y, lastCheckpoint.position.z);

        playerSprite.enabled = true;
        camera_Follow.enabled = true;
    }

}
