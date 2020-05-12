using UnityEngine;
using UnityEngine.UI;

public class CollectibleCounter : MonoBehaviour
{
    public static int collectiblesCollected = 0;
    public Text counter;

    [SerializeField]
    WaterSystems waterSystems;

    private void FixedUpdate()
    {
        counter.text = "Collectibles: " + collectiblesCollected + "/3";

        if (collectiblesCollected == 3)
        {
            waterSystems.AddMaxDash();
            collectiblesCollected = 0;
        }
    }

    public void AddCollectible()
    {
        collectiblesCollected++;
    }
}
