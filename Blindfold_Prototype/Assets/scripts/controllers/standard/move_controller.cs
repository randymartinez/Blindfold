using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_controller : MonoBehaviour {
	
	private Rigidbody rb;
	public float moveSpeed;

	public bool grounded = false;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update () {


	}

	void OnCollisionStay(Collision col)
	{
		if (col.collider.tag == "Ground")
		{
			grounded = true;
		}
	}

	void OnCollisionExit(Collision col)
	{
		if (col.collider.tag == "Ground")
		{
			grounded = false;
		}
	}

	//FixedUpdate is called once per physics step
	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
		{
			rb.AddForce(transform.forward * moveSpeed);
		}

		if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
		{
			rb.AddForce(-transform.forward * moveSpeed);
		}
	}
}