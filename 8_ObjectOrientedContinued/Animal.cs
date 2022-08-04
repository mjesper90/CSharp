using PretendUnity;

public abstract class Animal : MonoBehaviour
{
    public virtual void PlayAnimalSound() 
    {
        Console.WriteLine("The animal makes a sound");
    }
}
