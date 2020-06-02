using UnityEngine;

public class DashCollectibles : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer sprite;

    [SerializeField]
    BoxCollider2D boxCollider;

    [SerializeField]
    GameObject collectible;

    bool hasBeenPicked = false;

    public void HasBeenPicked()
    {
        hasBeenPicked = true;
        sprite.enabled = false;
        boxCollider.enabled = false;
    }

    public void PlayerHasDied()
    {
        if (hasBeenPicked == true)
        {
            hasBeenPicked = false;
            sprite.enabled = true;
            boxCollider.enabled = true;
        }
        
    }

    public void ReachedCheckpoint()
    {
        if (hasBeenPicked == true)
        {
            collectible.SetActive(false);
        }
    }

}
