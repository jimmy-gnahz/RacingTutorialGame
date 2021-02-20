using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountDown : MonoBehaviour
{
    public static double currentTime = 3;
    bool isTakingTime = false;
    public GameObject countDownText;

    public GameObject AI;


    // Update is called once per frame
    void Update()
    {
        if (isTakingTime == false)
        {
            StartCoroutine(SubTime());
        }

    }

    IEnumerator SubTime()
    {
        isTakingTime = true;
        AI.SetActive()
        // Display the text
        countDownText.GetComponent<Text>().text = currentTime + "";

        // reduce time by 1
        currentTime = currentTime - 1;

        // wait for 1 second
        yield return new WaitForSeconds(1f);

        isTakingTime = false;
    }
}
