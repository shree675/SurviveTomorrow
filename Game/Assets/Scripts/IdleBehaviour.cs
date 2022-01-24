using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehaviour : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       if((Input.GetKey("right shift") && (Input.GetKey("up") || Input.GetKey("left") || Input.GetKey("right") || Input.GetKey("down"))) || (Input.GetKey("left shift") && (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")))){
			animator.SetBool("walk",false);
            animator.SetBool("idle",false);
			animator.SetBool("run",true);
			return;
		}
		else if(Input.GetKey("up") || Input.GetKey("w")){
			animator.SetBool("walk",true);
			animator.SetBool("run",false);
			animator.SetBool("idle",false);
			return;
		}
		else if(Input.GetKey("left") || Input.GetKey("a")){
			animator.SetBool("walk",true);
			animator.SetBool("run",false);
			animator.SetBool("idle",false);
			return;
		}
		else if(Input.GetKey("down") || Input.GetKey("s")){
			animator.SetBool("run",false);
			animator.SetBool("walk",true);
			animator.SetBool("idle",false);
			return;
		}
		else if(Input.GetKey("right") || Input.GetKey("d")){
			animator.SetBool("run",false);
			animator.SetBool("walk",true);
			animator.SetBool("idle",false);
			return;
		}
		else{
			animator.SetBool("walk",false);
			animator.SetBool("run",false);
			animator.SetBool("idle",true);
		}
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }
}
