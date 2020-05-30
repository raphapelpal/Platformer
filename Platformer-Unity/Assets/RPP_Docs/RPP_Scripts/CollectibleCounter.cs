using UnityEngine;
using UnityEngine.UI;

public class CollectibleCounter : MonoBehaviour
{
    public static int collectiblesCollected = 0;
    public Text counter;

    [SerializeField] DashBar dashBar;

    //Fist feedback
    public Image im;

    private void Start()
    {
        im.enabled = false;
    }

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
