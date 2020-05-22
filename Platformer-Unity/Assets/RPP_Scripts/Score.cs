using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;

    [SerializeField] Timer timer;

    void FixedUpdate()
    {
        score.text = "Coins Picked: " + scoreValue;

        if (scoreValue == 10)
        {
            timer.AddTime();
            scoreValue = 0;
        }
    }

    public void AddCoin()
    {
        scoreValue += 1;
    }

}
