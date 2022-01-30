using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCharacter : MonoBehaviour
{

    public Animation anim;
    public AudioSource audioData;
    private bool isPlaying = false;

    void Start(){
        anim=GetComponent<Animation>();
        anim.Play("Walk");
    }

    void FixedUpdate()
    {
        if(ZombieCube.attack){
            if(!isPlaying){
                audioData.Play(0);
                isPlaying = true;
            }
            anim.Play("Attack1");
        }
        else{
            isPlaying=false;
            audioData.Stop();
            anim.Play("Walk");
        }
    }
}
