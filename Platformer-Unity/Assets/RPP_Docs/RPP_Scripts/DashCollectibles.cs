using UnityEngine;

public class DashCollectibles : MonoBehaviour
{
    [SerializeField]
    GameObject collectible1, collectible2, collectible3, collectible4;

    [SerializeField]
    CollectibleCounter collectibleCounter;

    bool tookCol1, tookCol2, tookCol3, tookCol4 = false;

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
        if (tookCol3 == true)
        {
            tookCol3 = false;
            collectible3.SetActive(true);
            collectibleCounter.im.enabled = false;
            collectibleCounter.im.Rebind();
        }
        if (tookCol4 == true)
        {
            tookCol4 = false;
            collectible4.SetActive(true);
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
        if (tookCol3 == true)
        {
            collectibleCounter.AddCollectible();
            tookCol3 = false;
            collectibleCounter.im.enabled = false;
            collectibleCounter.im.Rebind();
        }
        if (tookCol4 == true)
        {
            collectibleCounter.AddCollectible();
            tookCol4 = false;
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
    public void TookCol3()
    {
        tookCol3 = true;
    }
    public void TookCol4()
    {
        tookCol4 = true;
    }
}
