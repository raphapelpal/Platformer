using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] Text countdown;
    [SerializeField] float minTimer = 90f;
    float timer;


    private void Start()
    {
        timer = minTimer;
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
    }

    public void AddTime()
    {
        timer += 15f;
    }
}
