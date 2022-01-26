using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerCube cube;
	void FixedUpdate () {
		this.gameObject.transform.position=cube.transform.position+new Vector3(0.8f,0.5f,0.05f);
		this.gameObject.transform.rotation=Quaternion.Euler(15f, -90f, 0f);
	}
}
