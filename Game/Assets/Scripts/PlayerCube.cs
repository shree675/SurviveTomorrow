using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerCube : MonoBehaviour
{

    public Rigidbody rb;
    public Animator animator;
    private float time;
    private float exitTime;
    public AudioSource audioData;
    [SerializeField] Text text;

    void Start()
    {
        HealthBarHandler.SetHealthBarValue(1f);
        OxygenBarHandler.SetOxygenBarValue(1f);
        text.enabled=false;
        text.gameObject.SetActive(false);
        time=0;
        exitTime=0;
    }

    void FixedUpdate(){
        if(exitTime>5f){
            text.enabled=false;
            text.gameObject.SetActive(false);
            Application.Quit();
        }
        if(HealthBarHandler.GetHealthBarValue()<=0){
            animator.SetBool("die",true);
            text.enabled=true;
            text.gameObject.SetActive(true);
            exitTime+=Time.deltaTime;
            return;
        }
        if(OxygenBarHandler.GetOxygenBarValue()<=0){
            animator.SetBool("die",true);
            text.enabled=true;
            text.gameObject.SetActive(true);
            exitTime+=Time.deltaTime;
            return;
        }
        time+=Time.deltaTime;
        float h = 2.5f * Input.GetAxis("Mouse X");
        this.gameObject.transform.Rotate(0, h, 0);
        OxygenBarHandler.SetOxygenBarValue(OxygenBarHandler.GetOxygenBarValue() - 0.0002f);
        if (!animator.GetBool("jump") && Input.GetKey("space") && Math.Round(rb.velocity.y,2) == 0){
            rb.AddForce(0, 132 * Time.deltaTime, 0, ForceMode.VelocityChange);
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
