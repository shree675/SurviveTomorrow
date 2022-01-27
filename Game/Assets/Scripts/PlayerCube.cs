using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCube : MonoBehaviour
{

    public Rigidbody rb;
    public Animator animator;
    private float time;
    public AudioSource audioData;

    void Start()
    {
        HealthBarHandler.SetHealthBarValue(1f);
        OxygenBarHandler.SetOxygenBarValue(1f);
        time=0;
        // audioData = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        time+=Time.deltaTime;
        OxygenBarHandler.SetOxygenBarValue(OxygenBarHandler.GetOxygenBarValue() - 0.0002f);
        // HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.0002f);
        rb.mass=0.1f;
        if (!animator.GetBool("jump") && Input.GetKey("space"))
        {
            rb.AddForce(0, 50 * Time.deltaTime, 0, ForceMode.VelocityChange);
            if (Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))
            {
                // rb.AddForce(this.gameObject.transform.forward, ForceMode.VelocityChange);
            }
            if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
            {
                // rb.AddForce(this.gameObject.transform.forward, ForceMode.VelocityChange);
            }
            animator.SetBool("jump", true);
        }
        if (Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))
        {
            if(time>=0.3){
                audioData.Play(0);
                time=0;
            }
            this.gameObject.transform.Translate(Vector3.forward * 0.2f * Time.deltaTime);
        }
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            if(time>=0.3){
                audioData.Play(0);
                time=0;
            }
            this.gameObject.transform.Translate(Vector3.forward * 0.2f * Time.deltaTime);
        }
        if (Input.GetKey("right shift") && (Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right")))
        {
            if(time>=0.2){
                audioData.Play(0);
                time=0;
            }
            this.gameObject.transform.Translate(Vector3.forward * 0.4f * Time.deltaTime);
        }
        if (Input.GetKey("left shift") && (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")))
        {
            if(time>=0.2){
                audioData.Play(0);
                time=0;
            }
            this.gameObject.transform.Translate(Vector3.forward * 0.4f * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        animator.SetBool("jump", false);
    }

    void OnCollisionStay(Collision collision){
        animator.SetBool("jump", false);
    }

}
