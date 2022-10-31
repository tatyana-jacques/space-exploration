using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class Spaceship : IOrbitable
    {
        public string Model {get;set;}
        public float MaxLife { get; set; }
        public float ActualLife { get; set; }
        public bool IsUsable { get; set; }
        public float MaxSpeed { get; set; }

        
        public Dictionary<string, string> OrbitData()
        {
            return new Dictionary<string, string>(){
            {"Model", Model.ToString()},
            {"Maximum Life", MaxLife.ToString()},
            {"Actual Life", ActualLife.ToString()},
            {"Is usable ", IsUsable.ToString()},
            {"Maximun Speed", MaxSpeed.ToString()}
           
        };
        }

        public void IsOrbiting(IOrbitable orbitable)
        {
            Console.WriteLine ("Orbit data: ");
            foreach (var data in orbitable.OrbitData())
            {
                Console.WriteLine($"{data.Key}: {data.Value}");
            }
            Console.WriteLine("Orbita finalizada: ");

        }

        public void IsBeingDamaged (float damage){
            if (ActualLife==0){
                throw new InsufficientLife();
            }
            ActualLife = damage> ActualLife ? 0 : ActualLife - damage;
            CheckIfIsUsable();
        }

        private void CheckIfIsUsable(){
            var lifeLimit = MaxLife * 0.2;
            IsUsable = ActualLife > lifeLimit;
        }
    }
}