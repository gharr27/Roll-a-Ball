using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI timerText;
    public float time = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            //Check for Game Over
            player.SendMessage("TimerEnd");
        }
        else
        {
            time -= Time.deltaTime;
        }

        timerText.text = "Time: " + time.ToString("F0");
    }
}
