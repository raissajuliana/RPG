using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public Hero()
        {

        }

        public string name;

        public int level;

        public string heroType;

        public override string ToString(){
            return this.name + " " + this.level + " " + this.heroType;
        }

        public virtual string Attack(){
            return this.name + "atacou com a sua espada";
        }
    }
}