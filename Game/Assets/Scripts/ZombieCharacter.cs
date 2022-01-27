using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCharacter : MonoBehaviour
{

    public Animation anim;

    void Start(){
        anim=GetComponent<Animation>();
        anim.Play("Walk");
    }

    void FixedUpdate()
    {
        if(ZombieCube.attack){
            anim.Play("Attack1");
        }
        else{
            anim.Play("Walk");
        }
    }
}
