using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class Star: CelestialBody, IOrbitable
    {

        public Star ( string name, float size, int age, int mass, float gravity, float temperature, float luminosity, State state ) : base (name, size, age, mass, gravity)
        {
            Temperature = temperature;
            Luminosity = luminosity;
            StarState = state;

        }
        public float Temperature {get;set;}
        public float Luminosity {get;set;}
        public State StarState {get;set;}
    }
}