using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ability_class;

public class fighter : damage_calculator {

	private Dictionary<string, ability> moves;

	public fighter(string nameIn, int mHealth, int mEnergy, int str, int pot, float crit) :base(nameIn, mHealth, mEnergy, str, pot, crit){}
	
	void attack(fighter other){
		basicAttack(this, other);
	}

	void useAbility(fighter other, string moveName){
		//take in fighter and ability name
		moves[moveName].cast(this, other);
	}
	
	void learnAbility(ability newMove){
		moves[newMove.name] = newMove;
	}
}
	
