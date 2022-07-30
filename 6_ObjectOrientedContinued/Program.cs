List<Animal> MyFarmAnimals = new List<Animal>();

//MyFarmAnimals.Add(new Animal());
MyFarmAnimals.Add(new Dog());
MyFarmAnimals.Add(new Pig());

foreach(Animal animal in MyFarmAnimals){
    animal.PlayAnimalSound();
}

foreach(Animal animal in MyFarmAnimals){
    if(animal is FriendlyAnimalInterface){
        FriendlyAnimalInterface friendlyAnimal = (FriendlyAnimalInterface) animal;
        friendlyAnimal.Feed();
        friendlyAnimal.Pet();
    }
    if(animal is HostileAnimalInterface){
        HostileAnimalInterface anim = (HostileAnimalInterface) animal;
        bool didItWork = anim.Scare();
        if(didItWork == false){
            anim.Fight();
        }        
    }
}
Console.ReadLine();

/* Inheritance and interfaces assignment!
*
*   Create a "FriendlyAnimal" Class that should inherit from "Animal"
*   Refactor the Pig/Dog class to inherit from FriendlyAnimal
*   FriendlyAnimal must implement FriendlyAnimalInterface
*
*   Create a "HostileAnimal" Class that inherits from "Animal"
*   Create a Lion and an Alligator class that inherits from HostileAnimal
*   HostileAnimal must implement the HostileAnimalInterface
*
*   See the "CurrentDesign" and "FinishedDesign" files!
*
*/