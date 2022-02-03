using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutroSwitchScene : MonoBehaviour {

    public float time = 0;

    void FixedUpdate(){
        time += Time.deltaTime;
        if(time >= 26f){
            Application.LoadLevel("IntroScene");
        }
    }
}
