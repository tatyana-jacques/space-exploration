using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public abstract class CelestialBody
    {

        public CelestialBody( string name, float size, int age, float mass, float gravity){
            Name = name;
            Size = size;
            Age = age;
            Mass = mass;
            Gravity = gravity;

        }
        public string Name {get;set;} 
        public double Size {get;set;}
        public int Age {get;set;}
        public float Mass {get;set;}
        public float Gravity {get;set;}
    }
}