
using space_exploration;

bool gameIsRunning = true;
bool destinationIsChose = false;

Resource water = new Resource(name: "water", amount: 1000f);
Resource onyx = new Resource(name: "onyx", amount: 500f);
Resource iron = new Resource(name: "iron", amount: 1000f);
Resource gold = new Resource(name: "gold", amount: 5f);

Planet venus = new Planet();
venus.Age = 5000;
venus.Gravity = 10f;
venus.IsHabitable = true;
venus.Mass = 100f;
venus.Name = "Venus";
venus.Size = 6000f;
venus.AvailableResources = new List<Resource> { water, gold, iron };

Planet mars = new Planet();
mars.Age = 3000;
mars.Gravity = 30f;
mars.IsHabitable = true;
mars.Mass = 500f;
mars.Name = "Mars";
mars.Size = 7000f;
mars.AvailableResources = new List<Resource> { water, onyx, iron };

Planet jupiter = new Planet();
jupiter.Age = 2000;
jupiter.Gravity = 40f;
jupiter.IsHabitable = false;
jupiter.Mass = 300f;
jupiter.Name = "Jupiter";
jupiter.Size = 5000f;
jupiter.AvailableResources = new List<Resource> { gold, onyx, iron };

CollectSpaceship enterprise = new CollectSpaceship();
enterprise.MaxLife = 50f;
enterprise.ActualLife = 80f;
enterprise.IsUsable = true;
enterprise.CollectCapacity = 150f;
enterprise.Model = "Enterprise";
enterprise.MaxSpeed = 5000f;

TransportSpaceship millenium = new TransportSpaceship();
millenium.MaxLife = 200f;
millenium.ActualLife = 50f;
millenium.IsUsable = true;
millenium.PassagersAmount = 10;
millenium.Model = "Millenium";
millenium.MaxSpeed = 2000f;

WarSpaceship falcon = new WarSpaceship();
falcon.MaxLife = 400f;
falcon.ActualLife = 10f;
falcon.IsUsable = true;
falcon.AttackDamage = 30f;
falcon.Model = "Falcon";
falcon.MaxSpeed = 2000f;

var planets = new Dictionary<int, Planet>
{
    {1, venus},
    {2,mars},
    {3,jupiter}

};

var spaceships = new Dictionary<int, Spaceship>
{
    {1, enterprise},
    {2,millenium},
    {3,falcon}
};


while (gameIsRunning == true)
{
    Console.WriteLine(@$"Welcome to Space Exploration!Choose your spaceship type:
        1 - Collect Spaceship;
        2 - Transport Spaceship;
        3 - War Spaceship");

    try
    {
        var spaceshipChoice = int.Parse(Console.ReadLine());
        Spaceship chosenSpaceship = spaceships[spaceshipChoice];
        Console.WriteLine(chosenSpaceship.Model);
        Console.WriteLine(chosenSpaceship.GetType().ToString());


        while (destinationIsChose == false)
        {
            try
            {
                Console.WriteLine(@$"Choose your destination: 
                    1- Venus;
                    2 - Mars;
                    3 - Jupiter");
                var destinationChoice = int.Parse(Console.ReadLine());
                Planet chosenDestination = planets[destinationChoice];
                Console.WriteLine(chosenDestination.Name);
                destinationIsChose = true;


                if (chosenSpaceship.GetType().ToString() == "space_exploration.CollectSpaceship")
                {
                    try{
                    Console.WriteLine("Choose a resource: ");
                    var spaceshipCollectConverted = (CollectSpaceship)chosenSpaceship;
                    spaceshipCollectConverted.ChooseResource(chosenDestination);
                    spaceshipCollectConverted.CollectResource(chosenDestination);
                    }
                    catch (InsufficientResource exception)
                    {
                        Console.WriteLine (exception.Message);
                    }
                }

                else if (chosenSpaceship.GetType().ToString() == "space_exploration.WarSpaceship")
                {
                    Console.WriteLine(@$"Choose a spaceship to attack: 
                        1 - Enterprise;
                        2 - Millenium
                        3- Another Falcon");
                    try
                    {
                        var attackedSpaceshipChoice = int.Parse(Console.ReadLine());
                        Spaceship attackedChosenSpaceship = spaceships[attackedSpaceshipChoice];
                        Console.WriteLine(attackedChosenSpaceship.Model);
                        Console.WriteLine(attackedChosenSpaceship.GetType().ToString());
                        var spaceshipWarConverted = (WarSpaceship)chosenSpaceship;
                        spaceshipWarConverted.Attack(attackedChosenSpaceship);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }

                    catch (KeyNotFoundException e)
                    {

                        Console.WriteLine("Error: " + e.Message);
                    }
                }

                else
                {
                    var spaceshipTransportConverted = (TransportSpaceship)chosenSpaceship;
                    Console.WriteLine(@$"Spaceship passagers amount: {spaceshipTransportConverted.PassagersAmount}. 
                    Spaceship actual planet: {chosenDestination.Name}.");

                }



            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            catch (KeyNotFoundException e)
            {

                Console.WriteLine("Error: " + e.Message);
            }

        }
        destinationIsChose = false;


    }

    catch (FormatException e)
    {
        Console.WriteLine("Error: " + e.Message);
    }

    catch (KeyNotFoundException e)
    {

        Console.WriteLine("Error: " + e.Message);
    }


    Console.WriteLine("Do you want to continue the game? Dial yes to continue.");
    string playerResponse = Console.ReadLine();
    if (playerResponse != "yes")
    {
        gameIsRunning = false;
    }

}




