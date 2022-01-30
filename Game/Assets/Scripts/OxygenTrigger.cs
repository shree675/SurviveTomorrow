using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTrigger : MonoBehaviour{

    public AudioSource audioData;
    bool isPlaying = false;

    void OnTriggerStay(){
        if(!isPlaying){
            audioData.Play(0);
            isPlaying = true;
        }
        OxygenBarHandler.SetOxygenBarValue(OxygenBarHandler.GetOxygenBarValue() + 0.005f);
    }

    void OnTriggerExit(){
        audioData.Stop();
        isPlaying = false;
    }
}
