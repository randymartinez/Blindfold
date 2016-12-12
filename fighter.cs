using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ability_class;

public class fighter : damage_calculator {
	private static string name;

	private int health;
	private int maxHealth;
	private int energy;
	private int maxEnergy;
	private int strength; //basic attack strength
	private int potency; //ability strength
	private float critChance;
	private Dictionary<string, ability> moves;

	fighter(string nameIn, int mHealth, int mEnergy, int str, int pot, float crit){
		name = nameIn;
		int maxHealth = mHealth;
		int health = mHealth;
		int maxEnergy = mEnergy;
		int stength = str;
		int potency = pot;
		float critChance = crit;
	}
	
	void attack(fighter other){
		basic(this, other);
	}

	void useAbility(fighter other, string moveName){
		//take in fighter and ability name
		moves[moveName].cast(this, other);
	}
	
	void learnAbility(ability newMove){
		moves.add(newMove.name, newMove);
	}
}
	
