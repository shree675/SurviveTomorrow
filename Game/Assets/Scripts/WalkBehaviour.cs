using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkBehaviour : StateMachineBehaviour
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

	} 

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		bool a=false;
		if((Input.GetKey("right shift") && Input.GetKey("up")) || (Input.GetKey("left shift") && Input.GetKey("w"))){
			animator.SetBool("walk",false);
			animator.SetBool("run",true);
			animator.SetBool("idle",false);
			return;
		}
		if(Input.GetKey("up") || Input.GetKey("w")){
			animator.GetComponentInParent<PlayerCube>().transform.Translate(Vector3.forward*0.2f*Time.deltaTime);
			animator.SetBool("walk",true);
			animator.SetBool("idle",false);
			animator.SetBool("run",false);
			a=true;
		}
		if(a==false){
			animator.SetBool("walk",false);
			animator.SetBool("run",false);
			animator.SetBool("idle",true);
			return;
		}
	}

	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}
}
