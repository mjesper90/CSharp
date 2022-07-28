/*
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

*/

void HelloMethod(string message){
    Console.WriteLine(message);
    return;
};

HelloMethod("This string matches the methods parameter input!");
//HelloMethod(1); //Doesn't work


void FibonacciExample()
{
    int firstNumber = 1;
    int secondNumber = 1;
    int nextNumber = 0;
    Console.WriteLine("How many fibonacci numbers do you want me to calculate?");
    int input = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < input; i++)
    {
        nextNumber = firstNumber + secondNumber;
        Console.Write(" " + nextNumber);
        firstNumber = secondNumber;
        secondNumber = nextNumber;
    }
    Console.WriteLine(""); //Some empty space
    Console.ReadLine(); 
}

//FibonacciExample();

//Un-comment this code and fix the issues
/*
int RecursiveFibonacci(int first, int second, int count)
{
    count--;
    
    if(count == 0) {
        
    }else{
        return RecursiveFibonacci(?, ?, ?);
    }
}

int lastFibo = RecursiveFibonacci(1,1,5);
Console.WriteLine("Last fibo number was " + lastFibo);
Console.ReadLine(); 
*/



