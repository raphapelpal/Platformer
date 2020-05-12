using UnityEngine;

public class WaterSystems : MonoBehaviour
{
    public DashBar dashBar;

    [SerializeField]
    private CompositeCollider2D waterBoxCollider2D;

    int maxDash = 0;
    int dashLeft;
    int collectiblesColected;

    private void Start()
    {
        dashLeft = maxDash;
        dashBar.SetMaxDash(maxDash);
    }

    //Augment le nombre max de Dash
    public void AddMaxDash()
    {
        maxDash++;
        dashLeft = maxDash;
        dashBar.SetMaxDash(maxDash);
    }

    //Collectibles Partiels
    public void OptionalCollectibles()
    {
        collectiblesColected++;
    }

}
