using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class Planet: CelestialBody
    {
        public bool IsHabitable {get;set;}
        public List <Resources> AvailableResources = new List <Resources> ();

        
    }
}