using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbInteraction : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;

    string vbName;
    public GameObject VideoSurface_YSNP, VideoSurface_jalcas2, VideoSurface_ereyes28, ReviewSurface_jalcas2, ReviewSurface_ereyes28;
    public GameObject VideoBtnObj;
    public GameObject ReviewBtnObj;
    int count = 0;
    int count2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        VideoBtnObj = GameObject.Find("VideoButtonPlayer");

        VideoBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        ReviewBtnObj = GameObject.Find("ReviewButtonPlayer");

        ReviewBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //rtualButtonBehaviours = GetComponentsInParent<VirtualButtonBehaviour>();

        //r(int i = 0; i < virtualButtonBehaviours.Length; i++)
        //
        //  virtualButtonBehaviours[i].RegisterEventHandler(this);
        //
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;
        if(vbName == "VideoButtonPlayer")
        {
            VideoButtonPlayer();
        }
        else if(vbName == "ReviewButtonPlayer")
        {
            ReviewButtonPlayer();
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }

    public void VideoButtonPlayer()
    {
        if (count == 0)
        {
            VideoSurface_YSNP.SetActive(true);
            VideoSurface_jalcas2.SetActive(false);
            VideoSurface_ereyes28.SetActive(false);
            ReviewSurface_jalcas2.SetActive(false);
            ReviewSurface_ereyes28.SetActive(false);
        }
        else if (count == 1)
        {
            VideoSurface_YSNP.SetActive(false);
            VideoSurface_jalcas2.SetActive(true);
            VideoSurface_ereyes28.SetActive(false);
            ReviewSurface_jalcas2.SetActive(false);
            ReviewSurface_ereyes28.SetActive(false);
        }
        else if (count == 2)
        {
            VideoSurface_YSNP.SetActive(false);
            VideoSurface_jalcas2.SetActive(false);
            VideoSurface_ereyes28.SetActive(true);
            ReviewSurface_jalcas2.SetActive(false);
            ReviewSurface_ereyes28.SetActive(false);
        }
        else
        {
            count = -1;
        }
        count++;
        Debug.Log("Button pressed");
    }

    public void ReviewButtonPlayer()
    {
        if(count2 == 0)
        {
            ReviewSurface_jalcas2.SetActive(true);
            ReviewSurface_ereyes28.SetActive(false);
            VideoSurface_YSNP.SetActive(false);
            VideoSurface_jalcas2.SetActive(false);
            VideoSurface_ereyes28.SetActive(false);
        }
        else if(count2 == 1)
        {
            ReviewSurface_jalcas2.SetActive(false);
            ReviewSurface_ereyes28.SetActive(true);
            VideoSurface_YSNP.SetActive(false);
            VideoSurface_jalcas2.SetActive(false);
            VideoSurface_ereyes28.SetActive(false);
        }
        else
        {
            count2 = -1;
        }
        count2++;
        Debug.Log("Button pressed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Deactivate()
    {

    }
}
