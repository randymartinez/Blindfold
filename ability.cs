using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ability_class{

    public class ability : MonoBehaviour {

        public ability(string n,string d,int c,float s){name = n; scaling = s; desc = d;}
        private static string name;
        private static string desc;
        private static int cost;
        private static float scaling;

        public abstract void cast(fighter caster, fighter target);
        public string description(){return desc;}
            //..........
    }

    public class fire : ability{
        public fire():base("Fire","Special attack", 45, -0.4f){}

        public void cast(fighter caster, fighter target){
            special(caster, target, cost, scaling);
        }
    }

    public class poison: ability{
        public poison():base("Poison", "Applies damage over time", 15,-0.2f){}

        public void cast(fighter caster, fighter target){
            damageOverTime(caster, target, cost, scaling);
        }
    }

    public class ironKnuckle : ability{
        public ironKnuckle():base("ironKnuckle","Basic attack", 25, -0.4f){}

        public void cast(fighter caster, fighter target){
            basic(caster, target, cost, scaling);
        }
    }

    public class heal : ability{
        public heal():base("Heal","Heals target", 30, 0.5f){}

        public void cast(fighter caster, fighter target){
            special(caster,target, cost, scaling);
        }
    }
}