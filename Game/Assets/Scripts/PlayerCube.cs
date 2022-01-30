using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerCube : MonoBehaviour
{

    public Rigidbody rb;
    public Animator animator;
    private float time;
    public AudioSource audioData;
    public AudioSource audioDataFire;

    void Start()
    {
        HealthBarHandler.SetHealthBarValue(1f);
        OxygenBarHandler.SetOxygenBarValue(1f);
        time=0;
    }

    void FixedUpdate(){
        time+=Time.deltaTime;
        float h = 2.5f * Input.GetAxis("Mouse X");
        this.gameObject.transform.Rotate(0, h, 0);
        OxygenBarHandler.SetOxygenBarValue(OxygenBarHandler.GetOxygenBarValue() - 0.0002f);
        if (!animator.GetBool("jump") && Input.GetKey("space") && Math.Round(rb.velocity.y,2) == 0){
            rb.AddForce(0, 100 * Time.deltaTime, 0, ForceMode.VelocityChange);
            animator.SetBool("jump", true);
        }
        if(Input.GetKey("up") || Input.GetKey("w")){
            if(time>=0.3 && !animator.GetBool("jump")){
                audioData.Play(0);
                time=0;
            }
            this.gameObject.transform.Translate(Vector3.forward * 0.2f * Time.deltaTime);
        }
        if(Input.GetKey("right shift") && Input.GetKey("up")){
            if(time>=0.2 && !animator.GetBool("jump")){
                audioData.Play(0);
                time=0;
            }
            this.gameObject.transform.Translate(Vector3.forward * 0.4f * Time.deltaTime);
        }
        if(Input.GetKey("left shift") && Input.GetKey("w")){
            if(time>=0.2 && !animator.GetBool("jump")){
                audioData.Play(0);
                time=0;
            }
            this.gameObject.transform.Translate(Vector3.forward * 0.4f * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision){
        animator.SetBool("jump", false);
    }

    void OnCollisionStay(Collision collision){
    }

}
