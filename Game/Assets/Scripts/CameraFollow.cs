using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerCube cube;
	void FixedUpdate () {
		this.gameObject.transform.position=cube.transform.position+new Vector3(6f,2.5f,0.25f);
	}
}
