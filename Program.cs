
using space_exploration;
using space_exploration.Entities;

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
enterprise.ActualLife = 800f;
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
falcon.AttackDamage = 300f;
falcon.Model = "Falcon";
falcon.MaxSpeed = 2000f;

Star beta = new Star();
beta.Name = "Beta";
beta.Age = 2000000;
beta.Gravity = 10f;
beta.Luminosity = 20f;
beta.Mass = 300f;
beta.Size = 1000f;
beta.StarState = State.DwarfStar;
beta.Temperature = -9f;

Star alpha = new Star();
alpha.Name = "Alpha";
alpha.Age = 100000;
alpha.Gravity = 30f;
alpha.Luminosity = 100f;
alpha.Mass = 500f;
alpha.Size = 6000f;
alpha.StarState = State.RedSuperGiant;
alpha.Temperature = -20f;

Star gamma = new Star();
gamma.Name = "Gamma";
gamma.Age = 30000;
gamma.Gravity = 5f;
gamma.Luminosity = 260f;
gamma.Mass = 500f;
gamma.Size = 500f;
gamma.StarState = State.Supernova;
gamma.Temperature = 100f;

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

var stars = new Dictionary<int, Star>
{
    {1, alpha},
    {2,beta},
    {3,gamma}
};


while (gameIsRunning == true)
{
    Console.WriteLine("Welcome to Space Exploration! Choose your spaceship type:" +
        "\n1 - Collect Spaceship;" +
        "\n2 - Transport Spaceship;" +
        "\n3 - War Spaceship");
    Console.Write("Enter your choice number: ");

    try
    {
        var spaceshipChoice = int.Parse(Console.ReadLine());
        Spaceship chosenSpaceship = spaceships[spaceshipChoice];
        Console.WriteLine($"You chose {chosenSpaceship.Model}.");
        Console.WriteLine();
        Console.WriteLine("Before starting your journey, you can orbit a star. Choose one: " +
            "\n1 - Alpha;" +
            "\n2 - Beta;" +
            "\n3 - Gamma; ");
        Console.Write("Enter your choice number: ");
        try
        {

            var starChoice = int.Parse(Console.ReadLine());
            Star chosenStar = stars[starChoice];
            Console.WriteLine();
            Console.WriteLine($"You are orbitin {chosenStar.Name}. Star data: ");
            chosenSpaceship.IsOrbiting(chosenStar);
            Console.WriteLine();
        }

        catch (KeyNotFoundException)
        {

            Console.WriteLine("Ok. You chose not to orbit a star.");
        }



        while (destinationIsChose == false)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Choose your destination:" +
                    "\n1- Venus;" +
                    "\n2 - Mars;" +
                    "\n3 - Jupiter");
                Console.Write("Enter your choice number: ");
                var destinationChoice = int.Parse(Console.ReadLine());
                Planet chosenDestination = planets[destinationChoice];
                Console.WriteLine(chosenDestination.Name);
                destinationIsChose = true;


                if (chosenSpaceship.GetType().ToString() == "space_exploration.CollectSpaceship")
                {
                    try
                    {
                        Console.WriteLine("Choose a resource: ");
                        var spaceshipCollectConverted = (CollectSpaceship)chosenSpaceship;
                        spaceshipCollectConverted.ChooseResource(chosenDestination);
                        spaceshipCollectConverted.CollectResource(chosenDestination);
                    }
                    catch (InsufficientResource exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }

                else if (chosenSpaceship.GetType().ToString() == "space_exploration.WarSpaceship")
                {
                    Console.WriteLine();
                    Console.WriteLine("Choose a spaceship to attack: " +
                        "\n1 - Enterprise;" +
                        "\n2 - Millenium" +
                        "\n3 - Another Falcon");
                    Console.Write("Enter your choice number: ");
                    try
                    {
                        var attackedSpaceshipChoice = int.Parse(Console.ReadLine());
                        Spaceship attackedChosenSpaceship = spaceships[attackedSpaceshipChoice];
                        var spaceshipWarConverted = (WarSpaceship)chosenSpaceship;
                        try
                        {
                            spaceshipWarConverted.Attack(attackedChosenSpaceship);

                        }
                        catch (InsufficientLife emessage)
                        {
                            Console.WriteLine(emessage);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: you chose a nonexistent spaceship!");
                    }

                    catch (KeyNotFoundException)
                    {

                        Console.WriteLine("Error: you chose a nonexistent spaceship!");
                    }


                }

                else
                {
                    var spaceshipTransportConverted = (TransportSpaceship)chosenSpaceship;
                    bool setNewDestination = false;
                    spaceshipTransportConverted.CurrentPlanet = chosenDestination.Name;
                    Console.WriteLine(@$"You arrived on {chosenDestination.Name}. Choose your next destination: ");
                    while (setNewDestination == false)
                    {
                        try
                        {
                            Console.WriteLine(" " +
                            "\n1 - Venus;" +
                            "\n2 - Mars;" +
                            "\n3 - Jupiter");
                            var newDestinationChoice = int.Parse(Console.ReadLine());
                            Planet newDestination = planets[newDestinationChoice];
                            if (newDestination == chosenDestination)
                            {
                                Console.WriteLine("You have chose the actual planet. Choose a new destination.");
                            }
                            else
                            {
                                spaceshipTransportConverted.IsTraveling(newDestination.Name);
                                setNewDestination = true;
                            }

                        }

                        catch (FormatException)
                        {
                            Console.WriteLine("Error: you chose a nonexistent planet!");
                        }

                        catch (KeyNotFoundException)
                        {

                            Console.WriteLine("Error: you chose a nonexistent planet!");
                        }

                    }

                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: you chose a nonexistent planet!");
            }

            catch (KeyNotFoundException)
            {

                Console.WriteLine("Error: you chose a nonexistent spaceship!");
            }

        }
        destinationIsChose = false;
    }

    catch (FormatException)
    {
        Console.WriteLine("Error: you chose a nonexistent spaceship type!");
    }

    catch (KeyNotFoundException)
    {

        Console.WriteLine("Error: you chose a nonexistent spaceship type!");
    }

    Console.WriteLine();
    Console.WriteLine("Do you want to continue the game? Dial yes to continue.");
    string playerResponse = Console.ReadLine();
    if (playerResponse != "yes")
    {
        gameIsRunning = false;
    }

}




