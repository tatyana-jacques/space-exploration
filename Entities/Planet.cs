using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class Planet : CelestialBody, IOrbitable
    {

        public bool IsHabitable { get; set; }
        public List<Resource> AvailableResources { get; set; }

        public Dictionary<string, string> OrbitData()
        {
            return new Dictionary<string, string>(){
            {"Name", Name.ToString()},
            {"Size", Size.ToString()},
            {"Age", Age.ToString()},
            {"Mass", Mass.ToString()},
            {"Gravity", Gravity.ToString()},
            {"Is Habitable ", IsHabitable.ToString()},
            {"Resources: ", string.Join(", ", AvailableResources.Select(r=>r.Name))}

        };


        }
    }
}