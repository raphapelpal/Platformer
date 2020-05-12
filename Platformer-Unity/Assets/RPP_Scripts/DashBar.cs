using UnityEngine;
using UnityEngine.UI;


public class DashBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxDash(int dash)
    {
        slider.maxValue = dash;
        slider.value = dash;
    }

    public void SetDashLeft(int dash)
    {
        slider.value = dash;
    }


}
