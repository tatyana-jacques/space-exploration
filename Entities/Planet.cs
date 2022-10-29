using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class Planet: CelestialBody
    {

        public Planet ( string name, float size, int age, float mass, float gravity, bool isHabitable): base (name, size, age, mass, gravity)
        {
         IsHabitable = isHabitable;   
        }
        public bool IsHabitable {get;set;}
        public List <Resource> AvailableResources {get;set;}

        
    }
}