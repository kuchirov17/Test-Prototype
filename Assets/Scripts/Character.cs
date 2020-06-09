using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	public bool player = false;
	public string characterName;

	[Header("Movement")]
	public float speed = 2f;
	public float turnSpeed = 14f;

	protected Rigidbody rb;
	protected Vector3 curDir;
	protected Quaternion targetRot;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	public virtual void FixedUpdate()
	{
		rb.AddForce(transform.forward * speed, ForceMode.VelocityChange);

		if (curDir != Vector3.zero)
		{
			targetRot = Quaternion.LookRotation(curDir);
			if(rb.rotation != targetRot)
			{
				rb.rotation = Quaternion.RotateTowards(rb.rotation, targetRot, turnSpeed);
			}
		}
	}
	
	

}