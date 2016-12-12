using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage_calculator : MonoBehaviour {

	public static void crit(int critChance){
		Random random = new Random();
		int randomNumber = random.Next(0, 100);
		if(critChance*100 > randomNumber){return 2;}
		else{return 1;}
	}

	public static void damageOverTime(fighter caster, fighter target, float scaling){
		//-----------------------------------------------------------
		//This will be changed once turn based mechanic is added
		//-----------------------------------------------------------
		if(caster.energy > cost){
			target.health -= (caster.potency * scaling) + caster.potency;
		}
	}

	public static void special(fighter caster, fighter target, int cost,float scaling){
		if(caster.energy > cost){
			target.health -= (caster.potency * scaling) + (caster.potency * crit(caster.critChance)) + caster.potency;
		}
	}

	public static void basic(fighter caster, fighter target){
		target.health -= caster.strength + (caster.strength * crit(caster.critChance));
	}
	//Calculates the damage of a basic attack
}
