List<Animal> MyFarmAnimals = new List<Animal>();

MyFarmAnimals.Add(new Animal());
MyFarmAnimals.Add(new Dog());
MyFarmAnimals.Add(new Pig());


foreach(Animal animal in MyFarmAnimals){
    animal.PlayAnimalSound();
}
Console.ReadLine();