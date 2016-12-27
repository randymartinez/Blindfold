using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ability_class{

    public abstract class ability : MonoBehaviour {

        public ability(string n,string d,int c,float s){name = n; scaling = s; desc = d;}
        protected static string name;
        protected static string desc;
        protected static int cost;
        protected static float scaling;

        public abstract void cast(fighter caster, fighter target);
        public string description(){return desc;}
            //..........
    }

    public class fire : ability{
        public fire(): base("Fire","Special attack", 45, -0.4f){}

        public override void cast(fighter caster, fighter target){//(fighter caster, fighter target
            damage_calculator.specialAttack(caster, target, cost, scaling);
        }
    }

    public class poison: ability{
        public poison():base("Poison", "Applies damage over time", 15,-0.2f){}
        int duration = 5;

        public override void cast(fighter caster, fighter target){//base(fighter caster, fighter target)
            damage_calculator.damageOverTime(caster, target, cost, scaling, duration);
        }
    }

    public class ironKnuckle : ability{
        public ironKnuckle():base("ironKnuckle","Basic attack", 25, -0.4f){}

        public override void cast(fighter caster, fighter target){//base(fighter caster, fighter target)
            damage_calculator.basicAttack(caster, target, cost, scaling);
        }
    }

    public class heal : ability{
        public heal():base("Heal","Heals target", 30, 0.5f){}

        public override void cast(fighter caster, fighter target){//base(fighter caster, fighter target)
            damage_calculator.specialDefense(caster,target, cost, scaling);
        }
    }
}