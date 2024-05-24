using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;

    public static Timer time;

    private void Awake()
    {
        time = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.timeValue > 0)
        {
            GameManager.instance.timeValue -= Time.deltaTime;
        }

        else
        {
            GameManager.instance.timeValue = 0;
        }

        DisplayTime(GameManager.instance.timeValue);
    }
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        // Dakikalarý ve saniyeleri hesaplayýn
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);

        // Zamaný "MM:SS" formatýnda gösterin
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
