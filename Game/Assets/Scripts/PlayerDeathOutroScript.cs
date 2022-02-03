using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathOutroScript : MonoBehaviour {

    public float time = 0;

    void FixedUpdate(){
        time += Time.deltaTime;
        if(time >= 16f){
            Application.LoadLevel("IntroScene");
        }
    }
}

