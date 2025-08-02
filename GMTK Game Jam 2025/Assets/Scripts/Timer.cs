using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimerText;
    [SerializeField]float RemainingTime;

    private void Update()
    {
        if(RemainingTime >0)
        {
            RemainingTime -= Time.deltaTime;
        }
        else if(RemainingTime < 0)
        {
            RemainingTime = 0;
        }

        if(RemainingTime <= 10)
        {
            TimerText.color = Color.red;
        }

        int Minutes = Mathf.FloorToInt(RemainingTime / 60);
        int Seconds = Mathf.FloorToInt(RemainingTime % 60);
        TimerText.text = string.Format("{0:00} : {1:00}",Minutes,Seconds);
    }
}
