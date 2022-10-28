using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class CollectSpaceship : Spaceship
    {
        public float CollectMaxResources { get; set; }

        public string IsCollecting(Planet planet)
        {
            float currentResources = 0f;
            float finalResources = 0f;
            int index = 0;
        
            
            while (currentResources < CollectMaxResources)
            {
                currentResources += planet.AvailableResources[index].Amount;
                index++;
             
            }

            if (currentResources < CollectMaxResources)
            {
                finalResources = currentResources;
            }
            else {
                finalResources = CollectMaxResources;
            }


            return "Resources collected: " + finalResources;

        }
    }


}