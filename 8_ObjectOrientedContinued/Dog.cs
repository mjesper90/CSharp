public class Dog : FriendlyAnimal
{
    public override void PlayAnimalSound() 
    {
        Console.WriteLine("The dog says: wuff wuff");
    }

    public override void Feed()
    {
        Console.WriteLine("The dog was fed");
    }

    public override void Pet()
    {
        Console.WriteLine("The dog was petted");
    }
}