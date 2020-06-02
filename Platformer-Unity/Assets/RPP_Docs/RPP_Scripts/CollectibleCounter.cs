using UnityEngine;
using UnityEngine.UI;

public class CollectibleCounter : MonoBehaviour
{
    public static int collectiblesCollected = 0;
    public Text counter;

    [SerializeField]
    DashBar dashBar;

    private void FixedUpdate()
    {
        counter.text = "Collectibles: " + collectiblesCollected + "/2";

        if (collectiblesCollected == 2)
        {
            dashBar.AddMaxDash();
            collectiblesCollected = 0;
        }
    }

    public void AddCollectible()
    {
        collectiblesCollected++;
    }
}
