using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class CollectSpaceship : Spaceship
    {
        public float CollectMaxResources { get; set; }

      
        

        public void ChooseResource(Planet planet)
        {
           
            {
            Console.WriteLine("Choose a resource: ");

            foreach (Resource x in planet.AvailableResources)
            {
                Console.WriteLine(x.Name);
            }

            var pickedResourceName = Console.ReadLine();

            try
            {
                Resource existingResource = planet.AvailableResources.Where(p => p.Name == pickedResourceName).First();
                Console.WriteLine("Chosen resource: " + existingResource.Name + "; Amount: " + existingResource.Amount);
            }
            catch
            {
                throw new NonExistentResourceException();

            }
            }
        }


    }
}


