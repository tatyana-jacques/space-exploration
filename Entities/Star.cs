using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class Star: CelestialBody
    {
        public double Temperature {get;set;}
        public double Luminosity {get;set;}
        public State StarState {get;set;}
    }
}