using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage_calculator : MonoBehaviour {
	private static string name;
	private int health;
	private int maxHealth;
	private int energy;
	private int maxEnergy;
	private int strength; //basic attack strength
	private int potency; //ability strength
	private float critChance;

	public damage_calculator(string nameIn, int mHealth, int mEnergy, int str, int pot, float crit){
		name = nameIn;
		maxHealth = mHealth;
		health = mHealth;
		maxEnergy = mEnergy;
		strength = str;
		potency = pot;
		critChance = crit;
	}


	private static int crit(float critChance){
		int randomNumber = Random.Range(0, 100);
		if(critChance*100 > randomNumber){return 2;}
		else{return 1;}
	}

	public static void damageOverTime(fighter caster, fighter target, int cost, float scaling, int duration){
		//-----------------------------------------------------------
		//This will be changed once turn based mechanic is added
		//-----------------------------------------------------------
		if(caster.energy > cost){
			target.health -= (int)(caster.potency * scaling) + caster.potency;
		}
	}

	public static void specialAttack(fighter caster, fighter target, int cost,float scaling){
		if(caster.energy > cost){
			target.health -= (int)(caster.potency * scaling) + (caster.potency * crit(caster.critChance)) + caster.potency;
		}
	}

	public static void specialDefense(fighter caster, fighter target, int cost,float scaling){
		if(caster.energy > cost){
			target.health += (int)(caster.potency * scaling) + (caster.potency * crit(caster.critChance)) + caster.potency;
		}
	}

	public static void basicAttack(fighter caster, fighter target, int cost = 0, float scaling = 0.0f){
		target.health -= caster.strength + (caster.strength * crit(caster.critChance));
	}
	//Calculates the damage of a basic attack
}
