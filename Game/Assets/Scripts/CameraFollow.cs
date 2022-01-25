using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerCube cube;
	void FixedUpdate () {
		this.gameObject.transform.position=cube.transform.position+new Vector3(0.6f,0.25f,0.025f);
	}
}
