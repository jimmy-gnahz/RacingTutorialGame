using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCameraView : MonoBehaviour
{
    public GameObject FPCam;
    public GameObject TPCam;
    bool hoodCamEnabled = true;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (hoodCamEnabled)
            {
                FPCam.SetActive(true);
                TPCam.SetActive(false);
                hoodCamEnabled = false;
                return;
            }
            if (!hoodCamEnabled)
            {
                FPCam.SetActive(false);
                TPCam.SetActive(true);
                hoodCamEnabled = true;
            }
        }
    }
}
