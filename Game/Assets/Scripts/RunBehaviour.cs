using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunBehaviour : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		bool a=false;
		if((Input.GetKey("up") && Input.GetKey("right shift")) || (Input.GetKey("w") && Input.GetKey("left shift"))){
			animator.GetComponentInParent<PlayerCube>().transform.Translate(Vector3.forward*0.4f*Time.deltaTime);
			animator.SetBool("run",true);
			animator.SetBool("walk",false);
			animator.SetBool("idle",false);
			a=true;
		}
		if(!a){
			if((!Input.GetKey("right shift") && Input.GetKey("up")) || (!Input.GetKey("left shift") && Input.GetKey("w"))){
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
