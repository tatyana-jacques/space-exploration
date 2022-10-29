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

        public float MaxSpeed {get;set;}

        public Spaceship (float maxLife, float actualLife, bool isUsable, float collectCapacity, float MaxSpeed){
            MaxLife = maxLife;
            ActualLife = actualLife;
            IsUsable = isUsable;
            CollectCapacity = collectCapacity;
            
        }


        public void IsOrbiting (Star star){

            
            Console.WriteLine ("This Spaceship is orbiting:" + star.Name + "Star Temperature: " 
            + star.Temperature + "; Star Luminosity: " + star.Luminosity
            + "; Star State: " + star.StarState + ".");

        }
    }
}