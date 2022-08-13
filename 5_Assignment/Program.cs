//Un-comment below code and fix the issues
//Push to github

int RecursiveFibonacci(int first, int second, int count)
{
    count--;
    int next = first+second;
    Console.WriteLine(next);
    if(count == 0) {
        return next;
    }else{
        return RecursiveFibonacci(second, next, count);
    }
}

int lastFibo = RecursiveFibonacci(1,1,5);
Console.WriteLine("Last fibo number was " + lastFibo);
Console.ReadLine(); 



//Typewriter - recursion example
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