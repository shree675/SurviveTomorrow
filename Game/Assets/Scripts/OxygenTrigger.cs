using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTrigger : MonoBehaviour
{

    public AudioSource audioData;

    void OnTriggerStay()
    {
        audioData.Play(0);
        OxygenBarHandler.SetOxygenBarValue(OxygenBarHandler.GetOxygenBarValue() + 0.005f);
    }
}
