using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class Spaceship
    {
        public float MaxLife {get;set;}
        public float ActualLife {get;set;}

        public bool IsUsable {get;set; }

        public float CollectCapacity {get;set;}


        public string IsOrbiting (Star star){

            
            return "Star Characteristics: Star Temperature: " 
            + star.Temperature + "; Star Luminosity: " + star.Luminosity
            + "; Star State: " + star.StarState + ".";

        }
    }
}