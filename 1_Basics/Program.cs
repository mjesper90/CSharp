/* Todays assignment
*   Write a short story using the Console for input and output
*   Try to make use of as many of the below techniques as possible
*   Create a commit and push it to Github!
*/

#region Write own story

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
* There are many more which can be found in the Microsoft C# documentation, see link below.
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
    
    Console.WriteLine("You now have converted a text string into an integer!");
    number = number + 1;
    //number++;
    //number += 1;
    Console.WriteLine("I can now do math operations on it, and voila : " + number + " after I've added +1");
    Console.WriteLine("...");
    Console.ReadLine();

    Console.WriteLine("Next up we have the Float data type");
    Console.WriteLine("Float is decimal numbers");
    float OneThird = 1.0f/0.3f; //Notice the 'f' to indicate this number is a float value
    Console.WriteLine("Like for example 1/3, which gives : " + OneThird);

    Console.WriteLine("Lastly, the string data type.");
    Console.WriteLine("Strings are text, and can be found between quotation marks");
    Console.WriteLine("We have used strings to read and write to the console, this line is a string");
    Console.WriteLine("...");
    Console.ReadLine();
}


#endregion

Console.WriteLine("...The end...");
//Stops program from exiting until we press a key
Console.ReadLine();