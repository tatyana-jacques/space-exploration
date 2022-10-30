using space_exploration;

bool gameIsRunning = true;

Resource water = new Resource(name: "water", amount: 1000f);
Resource onyx = new Resource(name: "onyx", amount: 500f);
Resource iron = new Resource(name: "iron", amount: 1000f);
Resource gold = new Resource(name: "gold", amount: 5f);

Planet mars = new Planet();
mars.AvailableResources = new List<Resource> { water, onyx, iron };

CollectSpaceship enterprise = new CollectSpaceship(
    maxLife: 50f,
    actualLife: 80f, 
    isUsable: true, 
    collectCapacity: 150f, 
    collectMaxResource: 100f, 
    maxSpeed: 5000f);

//dicionario com as naves disponíveis
    //dicionario com todas as operações disponiveis



    while (gameIsRunning == true){
        Console.WriteLine ("Welcome to Space Exploration!Choose your destination");

         Console.WriteLine ("Choose your spaceship.");

         //if (dictionary item ==1)

         
         
         
         
         enterprise.ChooseResource(mars);


         Console.WriteLine ("Do you want to continue the game? Dial yes to continue.");
         string playerResponse = Console.ReadLine();
         if (playerResponse != "yes")
         {
            gameIsRunning = false;
         }



    }

   
   