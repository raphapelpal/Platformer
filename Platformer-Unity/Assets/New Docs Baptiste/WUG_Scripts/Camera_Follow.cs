using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform playerAzaès;
    public float cameraDistance = 30.0f;

    private void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(playerAzaès.position.x, playerAzaès.position.y, transform.position.z);
    }
}
