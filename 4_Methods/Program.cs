/* Introduction to methods/functions
<Return type> <Name> (paramaters)
{
    return <type>;
}

int Sum(int paramater1, int paramater2){
    int sum = paramater1 + paramater2;
    return sum;
}
int SumFromMethod = Sum(2,2);
Console.WriteLine("The calculated sum from the method was " + SumFromMethod);
Console.WriteLine("The calculated sum from the method was " + Sum(123,321));

*/

void HelloMethod(string message)
{
    Console.WriteLine(message);
    return;
};

HelloMethod("This string matches the methods parameter input!");
//HelloMethod(1); //Doesn't work


int FibonacciExample(int amount)
{
    int firstNumber = 1;
    int secondNumber = 1;
    int nextNumber = 0;

    for (int i = 0; i < amount; i++)
    {
        nextNumber = firstNumber + secondNumber;
        Console.Write(" " + nextNumber);
        firstNumber = secondNumber;
        secondNumber = nextNumber;
    }
    Console.WriteLine("\nLast number was : " + nextNumber);
    Console.ReadLine();
    return nextNumber;
}


Console.WriteLine("How many of the fibonacci sequence numbers do you want me to calculate?");
int input = Convert.ToInt32(Console.ReadLine());
int ReturnedNumber = FibonacciExample(input);




/* Teachers corner

* Overloading of methods

int haps(){
    return 0;
}

int haps(int snaps){
    return snaps;
}

*/