using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;

    void FixedUpdate()
    {
        score.text = "COINS PICKED: " + scoreValue;
    }

    public void AddCoin()
    {
        scoreValue += 1;
    }

}
