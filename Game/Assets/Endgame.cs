using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{

    private float time=0;

    // void Update()
    // {
    //     time += Time.deltaTime;
    //     if (time > 5)
    //     {
    //         Application.Quit();
    //     }
    // }

    void OnTriggerEnter(Collider collider) 
    {
        if(collider.name!="PlayerCube"){
            return;
        }
        if(time>=2f){

        }
    }
}
