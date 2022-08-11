List<Animal> MyFarmAnimals = new List<Animal>();

//MyFarmAnimals.Add(new Animal());
MyFarmAnimals.Add(new Dog());
MyFarmAnimals.Add(new Pig());


foreach (Animal animal in MyFarmAnimals)
{
    animal.PlayAnimalSound();
}

foreach (Animal animal in MyFarmAnimals)
{
    if (animal is FriendlyAnimal)
    {
        FriendlyAnimal friendlyAnimal = animal as FriendlyAnimal;
        if(friendlyAnimal != null){
            friendlyAnimal.Feed();
            friendlyAnimal.Pet();
        }
    }
    if (animal is HostileAnimalInterface)
    {
        HostileAnimalInterface anim = (HostileAnimalInterface)animal;
        bool didItWork = anim.Scare();
        if (didItWork == false)
        {
            anim.Fight();
        }
    }
}

Console.ReadLine();

