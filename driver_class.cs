using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver_class : MonoBehaviour {

	public fighter caster;
	public bool hi;
	//public fighter target("Target", 50, 50, 10, 10, 0.2f);
	// Use this for initialization
	void Start () {
		caster = new fighter ("Caster", 50, 50, 10, 10, 0.2f);
		hi = false;
		//caster.attack(target);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space))
		{
			hi = true;
		}
		Debug.Log("hi");
	}
}
