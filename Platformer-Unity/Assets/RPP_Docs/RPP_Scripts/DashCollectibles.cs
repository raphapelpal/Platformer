using UnityEngine;

public class DashCollectibles : MonoBehaviour
{
    [SerializeField]
    GameObject collectible1, collectible2;

    [SerializeField]
    CollectibleCounter collectibleCounter;

    bool tookCol1, tookCol2 = false;

    //Determines which collectible reappears if the player dies
    public void PlayerHasDied()
    {
        if (tookCol1 == true)
        {
            tookCol1 = false;
            collectible1.SetActive(true);
            collectibleCounter.im.enabled = false;
            collectibleCounter.im.Rebind();
        }
        if (tookCol2 == true)
        {
            tookCol2 = false;
            collectible2.SetActive(true);
            collectibleCounter.im.enabled = false;
            collectibleCounter.im.Rebind();
        }
    }

    //Resets the Bools after the player has successfully aquired an upgrade
    public void ReachedCheckpoint()
    {
        Debug.Log("Collectible Check");
        if (tookCol1 == true)
        {
            collectibleCounter.AddCollectible();
            tookCol1 = false;
            collectibleCounter.im.enabled = false;
            collectibleCounter.im.Rebind();
        } 
        if (tookCol2 == true)
        {
            collectibleCounter.AddCollectible();
            tookCol2 = false;
            collectibleCounter.im.enabled = false;
            collectibleCounter.im.Rebind();
        } 
    }

    public void TookCol1()
    {
        tookCol1 = true;
    }
    public void TookCol2()
    {
        tookCol2 = true;
    }
}
