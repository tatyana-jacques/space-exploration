using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class TransportSpaceship: Spaceship
    {
        public int PassagersAmount {get;set;}

        public string CurrentPlanet {get;set;}


        public void IsTraveling (string planet){
            Console.WriteLine ($"Traveling from {CurrentPlanet} to {planet}.");
        }

         
    }
}