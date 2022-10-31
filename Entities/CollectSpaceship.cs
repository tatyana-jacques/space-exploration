
namespace space_exploration
{
    public class CollectSpaceship : Spaceship
    {
        private bool resourceIsChose = false;
        public Resource ChoseResource { get; set; }
        public float CollectCapacity { get; set; }
        public void ChooseResource(Planet planet)
        {
            while (resourceIsChose == false)
            {
                foreach (Resource x in planet.AvailableResources)
                {
                    Console.WriteLine(x.Name);
                }

                var pickedResourceName = Console.ReadLine();

                    Resource existingResource = planet.AvailableResources.Where(p => p.Name == pickedResourceName).First();
                    Console.WriteLine("Chosen resource: " + existingResource.Name + "; Amount: " + existingResource.Amount);
                    resourceIsChose = true;
                    ChoseResource = existingResource;
               

            }
        }

        public void CollectResource(Planet planet)
        {
            Console.WriteLine($"Collecting {ChoseResource.Name} from {planet.Name}");
            Console.WriteLine($"Current resource amount: " + ChoseResource.Amount);

            if (ChoseResource.Amount < CollectCapacity)
            {
                throw new InsufficientResource(ChoseResource.Name);

            }
            ChoseResource.Amount -= CollectCapacity;
            Console.WriteLine($"Current resource amount: " + ChoseResource.Amount);

        }



    }
}


