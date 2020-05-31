using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;

    [SerializeField] Timer timer;
    [SerializeField] Animator animator;

    private void Start()
    {
        animator.enabled = false;
    }

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
        StartCoroutine(UIFeedbaack(animator));
    }

    IEnumerator UIFeedbaack (Animator anim)
    {
        anim.enabled = true;
        yield return new WaitForSeconds(0.95f);
        anim.enabled = false;
        anim.Rebind();
    }
}
