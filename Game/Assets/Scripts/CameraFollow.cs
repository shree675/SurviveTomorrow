using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraFollow : MonoBehaviour
{
    public PlayerCube cube;
	private Vector3 offset;

	void Start ()
	{
		offset = new Vector3(0.4f,0.2f,0f);
	}

	void FixedUpdate () {
		offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2.5f, Vector3.up) * offset;
        transform.position = cube.transform.position + offset;
        transform.LookAt(cube.transform.position+new Vector3(0f,0.1f,0f));
	}
}
