#region Assignment; Write your own story
/* Todays assignment
*   Run this program
*   Read and understand this programs source code
*   Write a short story using the Console for input and output
*   Try to make use of as many of the below techniques as possible
*/

//Console.WriteLine("...");
//Console.ReadLine();
//int.Parse("123");
//if, elseif, else

//bool ExampleBool = true;
//int ExampleInt = 123;
//float ExampleFloat = 123.21f;
//string ExampleString = "Example 123";
#endregion


#region Variables
Console.WriteLine("What is your name?");

//<Type> <Name> = <Value> ;
string myString = "This is how to define a string variable!";

//Reading a string from the console
myString = Console.ReadLine();

//Writing it back to the console
Console.WriteLine("Aaah, welcome " + myString + ", nice to meet you!");
#endregion

#region Data types
Console.WriteLine("Do you want to learn about the simplest data types?");
/*
* The four main basic types we we will work with in the beginning are:
* bool, Int, Float and String   
* bool or boolean, can only be 'true' or 'false'
* Int, or integer, is a whole number; 1, 2, 3
* Float is a decimal number; 3.14 or 7.777
* Strings is just text found between quotationmarks "This is a string, easy right?"
*
* Programmers use these different types to better communicate their thoughts and optimize the program
* C# have, at the time of writing; 10 different types of numbers, choosing the right ones can be key to your objective.
*
* There are many different data types which can be explored in the Microsoft C# documentation, see link below.
* https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
*/

string answer = Console.ReadLine();

bool LearnAboutDataTypes = false;
if(answer == "yes"){
    LearnAboutDataTypes = true;
}

if(LearnAboutDataTypes == true){
    Console.WriteLine("Then you have come to the right place!");
    Console.WriteLine("The 'bool' type can either be 'true' or 'false', nothing more, nothing less.");
    Console.WriteLine("When you answered 'yes', a bool named 'LearnAboutDataTypes' was set to 'true'");
    Console.WriteLine("And allowed for these messages!");
    Console.WriteLine("...");
    Console.ReadLine();
    
    Console.WriteLine("Now... The next data type we are gonna talk about is the integer, called an 'int'");
    Console.WriteLine("It is used to store whole numbers, like 1,2,3,4 and so on.");
    Console.WriteLine("Try inserting an integer now:");
    string inputFromConsole = Console.ReadLine();
    int number = int.Parse(inputFromConsole);
    
    Console.WriteLine("I have now converted a text string into an integer!");
    number = number + 1;
    //number++;
    //number += 1;
    Console.WriteLine("We can now do math operations on it, and voila, your number + 1 is equal to = " + number);
    Console.WriteLine("...");
    Console.ReadLine();

    Console.WriteLine("Next up we have the Float data type");
    Console.WriteLine("Float is decimal numbers, you can do math on it, just as we did with the integer");
    Console.WriteLine("Remember to use 'f'!");
    float OneThird = 1.0f/3.0f; //Notice the 'f' to indicate this number is a float value
    Console.WriteLine("Like for example 1.0f/3.0f, which gives : " + OneThird);
    Console.WriteLine("where as 1/3 gives = " + 1/3 + ". Because the computer thinks it is working with whole numbers (integers)");
    Console.WriteLine("...");
    Console.ReadLine();

    Console.WriteLine("Lastly, the string data type.");
    Console.WriteLine("Strings are text, and can be found between quotation marks");
    Console.WriteLine("We have used strings to read and write to the console, this line is a string");
    Console.WriteLine("...");
    Console.ReadLine();
}
#endregion
Console.WriteLine("...The end...");
Console.ReadLine(); //Stops program from exiting until we press a key


/* Teachers corner

* Operators; +, -, /, *, %, ++, --

* Casting
int.Parse()
Convert.ToInt32()
(int)
*/