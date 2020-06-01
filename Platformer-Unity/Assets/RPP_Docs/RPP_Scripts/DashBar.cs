using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class DashBar : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    int maxDash = 0;
    public int dashLeft;

    public DashMove dashMove;
    public bool canCountDash;

    public ParticleSystem upgradeFeedback;

    //The Images that count how many dashes the player has
    [SerializeField]
    SpriteRenderer dash1, dash2, dash3, dash4, dash5;

    [SerializeField]
    SpriteRenderer dashFill1, dashFill2, dashFill3, dashFill4, dashFill5;
   
    private void Start()
    {
        dash1.enabled = false;
        dash2.enabled = false;
        dash3.enabled = false;
        dash4.enabled = false;
        dash5.enabled = false;
        dashFill1.enabled = false;
        dashFill2.enabled = false;
        dashFill3.enabled = false;
        dashFill4.enabled = false;
        dashFill5.enabled = false;
    }

    private void Update()
    {

       if (maxDash > 5)
       {
            maxDash = 5;
       }
        //Follow the player
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }

    //Increases the quantity of dashes allowed to the player
    public void AddMaxDash()
    {
        maxDash++;
        dashLeft = maxDash;
        upgradeFeedback.Play();
        TotalDashes();
        DashMarkerFill();
    }

    //Refils the dashes
    public void DashRefil()
    {
        dashLeft = maxDash;
        DashMarkerFill();
    }

    //Decreases the dashes left
    public void UsedDash()
    {
        if (canCountDash == true)
        {
            dashLeft--;
            DashMarkerFill();
        }
    }

    //Defines how many dashes the player is allowed
    public void TotalDashes()
    {
        if (maxDash <= 1)
        {
            dash1.enabled = true;
            dashFill1.enabled = true;
        }
        else if (maxDash <= 2)
        {
            dash2.enabled = true;
            dashFill2.enabled = true;
        }
        else if (maxDash <= 3)
        {
            dash3.enabled = true;
            dashFill3.enabled = true;
        }
        else if (maxDash <= 4)
        {
            dash4.enabled = true;
            dashFill4.enabled = true;
        }
        else if (maxDash <= 5)
        {
            dash5.enabled = true;
            dashFill5.enabled = true;
        }
    }

    //Changes the fill of the dahs markers
    public void DashMarkerFill()
    {
        if (dashLeft == 0)
        {
            dashFill1.color = new Color(0, 0, 0, 0);
            dashFill2.color = new Color(0, 0, 0, 0);
            dashFill3.color = new Color(0, 0, 0, 0);
            dashFill4.color = new Color(0, 0, 0, 0);
            dashFill5.color = new Color(0, 0, 0, 0);
        }
        else if (dashLeft == 1)
        {
            dashFill1.color = new Color(255, 255, 255, 255);
            dashFill2.color = new Color(0, 0, 0, 0);
            dashFill3.color = new Color(0, 0, 0, 0);
            dashFill4.color = new Color(0, 0, 0, 0);
            dashFill5.color = new Color(0, 0, 0, 0);

        }
        else if (dashLeft == 2)
        {
            dashFill1.color = new Color(255, 255, 255, 255);
            dashFill2.color = new Color(255, 255, 255, 255);
            dashFill3.color = new Color(0, 0, 0, 0);
            dashFill4.color = new Color(0, 0, 0, 0);
            dashFill5.color = new Color(0, 0, 0, 0);
        }
        else if (dashLeft == 3)
        {
            dashFill1.color = new Color(255, 255, 255, 255);
            dashFill2.color = new Color(255, 255, 255, 255);
            dashFill3.color = new Color(255, 255, 255, 255);
            dashFill4.color = new Color(0, 0, 0, 0);
            dashFill5.color = new Color(0, 0, 0, 0);
        }
        else if (dashLeft == 4)
        {
            dashFill1.color = new Color(255, 255, 255, 255);
            dashFill2.color = new Color(255, 255, 255, 255);
            dashFill3.color = new Color(255, 255, 255, 255);
            dashFill4.color = new Color(255, 255, 255, 255);
            dashFill5.color = new Color(0, 0, 0, 0);
        }
        else if (dashLeft == 5)
        {
            dashFill1.color = new Color(255, 255, 255, 255);
            dashFill2.color = new Color(255, 255, 255, 255);
            dashFill3.color = new Color(255, 255, 255, 255);
            dashFill4.color = new Color(255, 255, 255, 255);
            dashFill5.color = new Color(255, 255, 255, 255);
        }
    }

    public void InfiniteDash(bool tog)
    {
        canCountDash = tog;
    }
}
