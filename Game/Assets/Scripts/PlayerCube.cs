using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCube : MonoBehaviour{

    public Rigidbody rb;
    public Animator animator;

    void FixedUpdate(){
        if(!animator.GetBool("jump") && Input.GetKey("space")){
            rb.AddForce(0,150*Time.deltaTime,0,ForceMode.VelocityChange);
            if(Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right")){
                rb.AddForce(this.gameObject.transform.forward,ForceMode.VelocityChange);
            }
            if(Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")){
                rb.AddForce(this.gameObject.transform.forward,ForceMode.VelocityChange);
            }
            animator.SetBool("jump", true);
        }
        if(Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right")){
            this.gameObject.transform.Translate(Vector3.forward*0.4f*Time.deltaTime);
        }
        if(Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")){
            this.gameObject.transform.Translate(Vector3.forward*0.4f*Time.deltaTime);
        }
        if(Input.GetKey("right shift") && (Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))){
            this.gameObject.transform.Translate(Vector3.forward*0.6f*Time.deltaTime);
        }
        if(Input.GetKey("left shift") && (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))){
            this.gameObject.transform.Translate(Vector3.forward*0.6f*Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision){
        animator.SetBool("jump",false);
    }

}
