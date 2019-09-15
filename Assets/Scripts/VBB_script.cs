using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBB_script: MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;
    public Animator cubeAni;
    public GameObject gandalf;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("You Shall Not Pass!");
        
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
        gandalf.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
    }
}