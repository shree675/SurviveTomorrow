using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunBehaviour : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		bool a=false;
		if(Input.GetKey("up") && Input.GetKey("right shift")){
			animator.GetComponentInParent<PlayerCube>().transform.rotation=Quaternion.Euler(0f, -90f, 0f);
			animator.GetComponentInParent<PlayerCube>().transform.Translate(Vector3.forward*0.6f*Time.deltaTime);
			animator.SetBool("run",true);
			animator.SetBool("walk",false);
			animator.SetBool("idle",false);
			a=true;
		}
		else if(Input.GetKey("down") && Input.GetKey("right shift")){
			animator.GetComponentInParent<PlayerCube>().transform.rotation=Quaternion.Euler(0f, 90f, 0f);
			animator.GetComponentInParent<PlayerCube>().transform.Translate(Vector3.forward*0.6f*Time.deltaTime);
			animator.SetBool("run",true);
			animator.SetBool("walk",false);
			animator.SetBool("idle",false);
			a=true;
		}
		else if(Input.GetKey("left") && Input.GetKey("right shift")){
			animator.GetComponentInParent<PlayerCube>().transform.rotation=Quaternion.Euler(0f, -180f, 0f);
			animator.GetComponentInParent<PlayerCube>().transform.Translate(Vector3.forward*0.6f*Time.deltaTime);
			animator.SetBool("run",true);
			animator.SetBool("walk",false);
			animator.SetBool("idle",false);
			a=true;
		}
		else if(Input.GetKey("right") && Input.GetKey("right shift")){
			animator.GetComponentInParent<PlayerCube>().transform.rotation=Quaternion.Euler(0f, 0f, 0f);
			animator.GetComponentInParent<PlayerCube>().transform.Translate(Vector3.forward*0.6f*Time.deltaTime);
			animator.SetBool("run",true);
			animator.SetBool("walk",false);
			animator.SetBool("idle",false);
			a=true;
		}
		if(!a){
			if(!Input.GetKey("right shift") && (Input.GetKey("up") || Input.GetKey("left") || Input.GetKey("right") || Input.GetKey("down"))){
				animator.SetBool("walk",true);
				animator.SetBool("run",false);
				animator.SetBool("idle",false);
				return;
			}
			animator.SetBool("walk",false);
			animator.SetBool("run",false);
            animator.SetBool("idle",true);
			return;
		}
	}

	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}
}
