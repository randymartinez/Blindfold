using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat_controller : MonoBehaviour {


	private enum CombatStates{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN
	}

	private CombatStates currentState;

	// Use this for initialization
	void Start () {
		currentState = CombatStates.START;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
