using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class WarSpaceship: Spaceship
    {
        public float AttackDamage {get;set;}


        public string Attack (Spaceship spaceship){

            spaceship.ActualLife -= AttackDamage;
            if (spaceship.ActualLife<= spaceship.MaxLife * 0.2)
            {
                spaceship.IsUsable = false;
            }


            return "Attacked spaceship life is: " + spaceship.ActualLife + " ; The spaceship is usable: " + spaceship.IsUsable;
        }
    }
}