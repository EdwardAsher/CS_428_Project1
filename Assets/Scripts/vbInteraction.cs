using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbInteraction : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;

    string vbName;
    public GameObject VideoSurface_YSNP, VideoSurface_jalcas2, VideoSurface_ereyes28;
    public GameObject vbBtnObj;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("VideoButtonPlayer");

        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //rtualButtonBehaviours = GetComponentsInParent<VirtualButtonBehaviour>();

        //r(int i = 0; i < virtualButtonBehaviours.Length; i++)
        //
        //  virtualButtonBehaviours[i].RegisterEventHandler(this);
        //
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (count == 0)
        {
            VideoSurface_YSNP.SetActive(true);
            VideoSurface_jalcas2.SetActive(false);
            VideoSurface_ereyes28.SetActive(false);
        }
        else if(count == 1)
        {
            VideoSurface_YSNP.SetActive(false);
            VideoSurface_jalcas2.SetActive(true);
            VideoSurface_ereyes28.SetActive(false);
        }
        else if(count == 2)
        {
            VideoSurface_YSNP.SetActive(false);
            VideoSurface_jalcas2.SetActive(false);
            VideoSurface_ereyes28.SetActive(true);
        }
        else
        {
            count = -1;
        }
        count++;
         
        //Name = vb.VirtualButtonName;
        //(vbName == "VideoButtonPlayer")
        //
        //  VideoButtonPlayer();
        //
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

    void VideoButtonPlayer()
    {
        //deoSurface_YSNP.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Deactivate()
    {

    }
}
