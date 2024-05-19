using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int  level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string Attack()
        {
            return this.name + "Atacou com sua magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6) 
            {
                return this.name + "Lançou a braba!";
            } else {
                return this.name + "Lançou magia fraca :(";
            }
            
        }
    }
}