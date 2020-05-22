using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class DashBar : MonoBehaviour
{
    int maxDash = 0;
    public int dashLeft;

    public DashMove dashMove;

    //The Images that count how many dashes the player has
    [SerializeField]
    Image dash1;
    [SerializeField]
    Image dash2;
    [SerializeField]
    Image dash3;
    [SerializeField]
    Image dash4;
    [SerializeField]
    Image dash5;

    private void Start()
    {
        dash1.enabled = false;
        dash2.enabled = false;
        dash3.enabled = false;
        dash4.enabled = false;
        dash5.enabled = false;
    }

    private void Update()
    {

       if (maxDash > 5)
       {
            maxDash = 5;
       }
       if (Input.GetKeyDown(KeyCode.R))
       {
            DashRefil();
            Debug.Log("Refil");
       }
       
    }

    //Increases the quantity of dashes allowed to the player
    public void AddMaxDash()
    {
        maxDash++;
        dashLeft = maxDash;
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
        Debug.Log("UsedDash has been called");
        dashLeft --;
        DashMarkerFill();
    }

    //Defines how many dashes the player is allowed
    public void TotalDashes()
    {
        if (maxDash <= 1)
        {
            dash1.enabled = true;
        }
        else if (maxDash <= 2)
        {
            dash2.enabled = true;
        }
        else if (maxDash <= 3)
        {
            dash3.enabled = true;
        }
        else if (maxDash <= 4)
        {
            dash4.enabled = true;
        }
        else if (maxDash <= 5)
        {
            dash5.enabled = true;
        }
    }

    //Changes the fill of the dahs markers
    public void DashMarkerFill()
    {
        if (dashLeft == 0)
        {
            dash1.color = Color.red;
            dash2.color = Color.red;
            dash3.color = Color.red;
            dash4.color = Color.red;
            dash5.color = Color.red;
        }
        else if (dashLeft == 1)
        {
            dash1.color = Color.white;
            dash2.color = Color.red;
            dash3.color = Color.red;
            dash4.color = Color.red;
            dash5.color = Color.red;
        }
        else if (dashLeft == 2)
        {
            dash1.color = Color.white;
            dash2.color = Color.white;
            dash3.color = Color.red;
            dash4.color = Color.red;
            dash5.color = Color.red;
        }
        else if (dashLeft == 3)
        {
            dash1.color = Color.white;
            dash2.color = Color.white;
            dash3.color = Color.white;
            dash4.color = Color.red;
            dash5.color = Color.red;
        }
        else if (dashLeft == 4)
        {
            dash1.color = Color.white;
            dash2.color = Color.white;
            dash3.color = Color.white;
            dash4.color = Color.white;
            dash5.color = Color.red;
        }
        else if (dashLeft == 5)
        {
            dash1.color = Color.white;
            dash2.color = Color.white;
            dash3.color = Color.white;
            dash4.color = Color.white;
            dash5.color = Color.white;
        }
    }
}
