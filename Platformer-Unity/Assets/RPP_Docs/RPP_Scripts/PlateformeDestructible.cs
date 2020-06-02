using System.Collections;
using UnityEngine;

public class PlateformeDestructible : MonoBehaviour
{
    [SerializeField]
    BoxCollider2D boxCollider;
    [SerializeField]
    GameObject platform;
    [SerializeField]
    float timeToDestruction = 1.5f;
    private void FixedUpdate()
    {
        OnTriggerEnter2D(boxCollider);
    }

    void OnTriggerEnter2D(Collider2D boxCollider2D)
    {
        if (boxCollider2D.CompareTag("Player"))
        {
            Debug.Log("The player is in the platform");
            StartCoroutine(SelfDestruction(platform));
        }
    }

    IEnumerator SelfDestruction(GameObject platform)
    {
        yield return new WaitForSeconds(timeToDestruction);
        platform.SetActive(false);
    }

}
