using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCube : MonoBehaviour
{

    public static bool attack=false;
    private float t;
    public PlayerCube cube;

    void Start(){
        t=0;
    }

    void FixedUpdate(){
        t+=Time.deltaTime;
        if(t>=5){
            this.gameObject.transform.rotation=Quaternion.Euler(0,Random.Range(-180.0f,180.0f),0);
            t=0;
        }
        this.gameObject.transform.Translate(Vector3.forward*0.14f*Time.deltaTime);
    }

    void OnTriggerStay(Collider collider){
        if(collider.name=="PlayerCube"){
            HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.001f);
            attack=true;
            transform.LookAt(collider.transform.position);
        }
    }

    void OnTriggerExit(){
        attack=false;
    }

    // void OnCollisionStay(Collision collision){
    //     if(collision.collider.name=="PlayerCube"){
    //         HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.001f);
    //         attack=true;
    //         transform.LookAt(collision.collider.transform.position);
    //     }
    // }

    // void OnCollisionExit(){
    //     attack=false;
    // }
}
