using UnityEngine;
using UnityEngine.UI;

public class CollectibleCounter : MonoBehaviour
{
    static int collectiblesCollected = 0;
    public Text counter;

    [SerializeField] DashBar dashBar;

     public Animator im;

    public ParticleSystem collectibleFeedback;


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
        collectibleFeedback.Play();

    }
}
