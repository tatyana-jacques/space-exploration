using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class CelestialBody
    {
        public string? Name {get;set;} 
        public double Size {get;set;}
        public int Age {get;set;}

        public double Mass {get;set;}

        public double Gravity {get;set;}
    }
}