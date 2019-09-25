/*==============================================================================
Copyright (c) 2019 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using Vuforia;
/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class  Animations: DefaultTrackableEventHandler, ITrackableEventHandler
{
    #region PROTECTED_MEMBER_VARIABLES

    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    #endregion // UNITY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    public GameObject ring;
    //public Component halo;
    //public Behaviour halo;

    /*private new void Start()
    {
        //GetComponent(Halo).enabled = false;
        halo = GetComponent("Halo");
        halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
        Debug.Log("Hello");
        //cubeAni.GetComponent<Animator>();
    }*/

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public new void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        //halo = GetComponent<Halo>();

        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName +
                  " " + mTrackableBehaviour.CurrentStatus +
                  " -- " + mTrackableBehaviour.CurrentStatusInfo);
        Debug.Log("Hello");

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if (mTrackableBehaviour.TrackableName == "Back_Cover")
            {
                //ring = Component.Find("You Shall Not Pass!");
                //halo.enabled = true;
                //ring.Halo.setActive(true);
                //halo.GetType().GetProperty("enabled").SetValue(halo, true);
                //GetComponent<Behaviour>().enabled = true;
                SetHalo(true);
                OnTrackingFound();
            }
            else
            {
                //halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
                //GetComponent<Behaviour>().enabled = false;
                //halo.enabled = false;
                SetHalo(false);
                OnTrackingFound();
            }
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            //GetComponent<Behaviour>().enabled = false;
            //halo.enabled = false;
            SetHalo(false);
            OnTrackingLost();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            //GetComponent<Behaviour>().enabled = false;
            //halo.enabled = false; GetComponent("Halo").enabled = false;
            SetHalo(false);
            OnTrackingLost();
        }
    }

    private void SetHalo(bool turnOn)
    {

        Component halo = GetComponent("Halo");

        if (turnOn)
        {
            halo.GetType().GetProperty("enabled").SetValue(halo, true, null);
        }
        else
        {
            halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
        }

    }

    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS


    #endregion // PROTECTED_METHODS
}
