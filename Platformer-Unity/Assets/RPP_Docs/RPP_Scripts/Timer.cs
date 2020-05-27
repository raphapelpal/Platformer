using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] Text countdown;
    [SerializeField] float minTimer = 90f;
    float timer;

    //Bonus Feedback
    [SerializeField] Text bonusFeedback;
    [SerializeField] Animator anim;


    private void Start()
    {
        anim.enabled = false;
        timer = minTimer;
        bonusFeedback.enabled = false;
    }

    private void FixedUpdate()
    {
            if (timer >= 0.0f)
            {
                timer -= Time.fixedDeltaTime;
                countdown.text = timer.ToString("F");
            }
            else if (timer < 0.0f)
            {
                countdown.text = "0.00";
                SceneManager.LoadScene("GameOver");
            }

            /*if (Input.GetKeyDown(KeyCode.T))
            {
                StartCoroutine(ShowBonus());
            }*/
        
    }

    public void AddTime()
    {
        timer += 15f;
        StartCoroutine(ShowBonus());
    }

    IEnumerator ShowBonus()
    {
        bonusFeedback.enabled = true;
        anim.enabled = true;
        yield return new WaitForSeconds(1.35f);
        bonusFeedback.enabled = false;
        anim.enabled = false;
        anim.Rebind();
    }
}
