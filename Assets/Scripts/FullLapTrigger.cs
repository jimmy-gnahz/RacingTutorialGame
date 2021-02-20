using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullLapTrigger : MonoBehaviour
{

    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;
    public GameObject LapNumberNumber;
    public GameObject bestTime;


    void OnTriggerEnter()
    {
        LapCompleteTrigger.SetActive(false);
        HalfLapTrigger.SetActive(true);

        bestTime.GetComponent<Text>().text = TimerText.currentTime + "";
        TimerText.currentTime = 0;
    }
}