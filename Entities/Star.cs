
namespace space_exploration.Entities
{
    public class Star : CelestialBody, IOrbitable
    {

        public float Temperature { get; set; }
        public float Luminosity { get; set; }
        public State StarState { get; set; }

        public Dictionary<string, string> OrbitData()
        {
            return new Dictionary<string, string>(){
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

        public void IsOrbitating()
        {
            Console.WriteLine("Now you are orbitating a star.");

        }

    }


}