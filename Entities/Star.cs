using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class Star: CelestialBody, IOrbitable
    {

       
        public float Temperature {get;set;}
        public float Luminosity {get;set;}
        public State StarState {get;set;}

public Dictionary <string,string> OrbitData(){
        return new Dictionary <string,string>(){
            {"Name", Name.ToString()},
            {"Size", Size.ToString()},
            {"Age", Age.ToString()},
            {"Mass", Mass.ToString()},
            {"Gravity", Gravity.ToString()},
            {"Temperature", Temperature.ToString()},
            {"Luminosidade",Luminosity.ToString()},
            {"State", StarState.ToString()}

        };

}
    }
}