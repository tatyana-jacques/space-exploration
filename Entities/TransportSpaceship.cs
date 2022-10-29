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

         public TransportSpaceship (float maxLife, float actualLife, bool isUsable, float collectCapacity, int passagersAmount, string currentPlanet, float maxSpeed): 
        base (maxLife, actualLife, isUsable, collectCapacity, maxSpeed){
            PassagersAmount = passagersAmount;
            CurrentPlanet = currentPlanet;

        }
    }
}