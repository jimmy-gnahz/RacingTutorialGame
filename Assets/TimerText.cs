using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimerText : MonoBehaviour
{
    public static double currentTime = 0;
    bool isTakingTime = false;
    public GameObject timerText;
    

    // Update is called once per frame
    void Update()
    {
        if (isTakingTime == false)
        {
            StartCoroutine(AddTime());
        }

    }

    IEnumerator AddTime()
    {
        isTakingTime = true;
        timerText.GetComponent<Text>().text = currentTime + "";
        currentTime = Math.Round(currentTime + 0.1,2);
        yield return new WaitForSeconds(0.1f);
        isTakingTime = false;
    }
}
