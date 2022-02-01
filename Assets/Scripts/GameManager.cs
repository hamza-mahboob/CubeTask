using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text textTime, textTotal;
    public float totalTime, time, minutes, seconds, totalMinutes, totalSeconds;
    public static bool isGameStarted;
    // Start is called before the first frame update
    void Start()
    {
        isGameStarted = true;
        time = 90;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Main running");
        Debug.Log((int)time);

        //check if we have time, if yes, then subtract from time left and add to time elapsed
        if (time > 0)
        {
            totalTime += Time.deltaTime;
            time -= Time.deltaTime;
        }
        else
        {
            //if no time left then set isGameStarted to false
            time = 0;
            isGameStarted = false;
        }

        //convert float to minutes and seconds for time left
        minutes = (int)(time / 60);
        seconds = time % 60;

        //convert float to minnutes and seconds for time elapsed
        totalMinutes = (int)(totalTime / 60);
        totalSeconds = totalTime % 60;

        //set text to the calculated time values
        textTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        textTotal.text = string.Format("{0:00}:{1:00}", totalMinutes, totalSeconds);

    }
}
