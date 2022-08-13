#region Introduction to methods/functions

/* Syntax
<Return type> <Name> (paramaters)
{
    return <type>;
}
*/ 


/* Basic Examples */
int Sum(int paramater1, int paramater2){
    int sum = paramater1 + paramater2;
    return sum;
}
int SumFromMethod = Sum(2,2);
Console.WriteLine("The calculated sum from the method was " + SumFromMethod);
Console.WriteLine("The calculated sum from the method was " + Sum(123,321));

void HelloMethod(string message)
{
    Console.WriteLine(message);
    return;
};

HelloMethod("This string matches the methods parameter input!");
//HelloMethod(1); //Doesn't work

#endregion

#region Linear fibonacci
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

#endregion

#region recursive typewriter

string TypeWriter(string input){
    if(input.Length > 0){
        string firstCharacter = input.Substring(0, 1);
        string restOfInput = input.Remove(0, 1);
        Console.Write(firstCharacter);
        Thread.Sleep(50);
        return TypeWriter(restOfInput);
    }else{
        return "";
    }
}

string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore";
TypeWriter(text);
Console.ReadLine(); 

#endregion


/* Teachers corner

* Overloading of methods

int haps(){
    return 0;
}

int haps(int snaps){
    return snaps;
}

*/


