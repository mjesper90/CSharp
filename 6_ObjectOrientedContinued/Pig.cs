public class Pig : FriendlyAnimal
{
    public override void PlayAnimalSound() 
    {
        Console.WriteLine("The pig says: oink oink");
    }

    public override void Feed()
    {
        Console.WriteLine("Pig was fed");
    }

    public override void Pet()
    {
        Console.WriteLine("Pig was petted");
    }
}

