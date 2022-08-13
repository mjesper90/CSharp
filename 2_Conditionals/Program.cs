#region Conditions; if, else if, else

Console.WriteLine("Look at the source code to learn more about conditionals!");
string StringInputFromConsole = Console.ReadLine();

bool BooleanInput = false;
if(StringInputFromConsole == "haps" || StringInputFromConsole == "snaps")
{
  BooleanInput = true;
}

if(BooleanInput == true)
{
  Console.WriteLine("Conditions are easy!"); 
}
else
{
  Console.WriteLine("Read the source code for this program to learn more!"); 
}

if(2 > 5)
{
  Console.WriteLine("2 was greater than 5");
}
else if(2+2 == 5)
{
  Console.WriteLine("2+2 was equal to 5");
}
else if(4 != 4)
{
  Console.WriteLine("4 is NOT equal to 4");
}
else
{
  if(2*2 >= 5)
  {
      Console.WriteLine("2 times 2 is greater than or equal to 5");    
  }
  else if(true)
  {
    Console.WriteLine("true");
  }

  if(false == false && true == true)
  {
    Console.WriteLine("false is equal to false AND true is equal to true");
  }
}



#endregion


#region Conditions; Switch

/*
switch(expression) 
{
  case x:
    // code block
    break;
  case y:
    // code block
    break;
  default:
    // code block
    break;
}
*/

Console.WriteLine("Input a number between 1 and 7");
string inputFromConsole = Console.ReadLine();
int day = int.Parse(inputFromConsole);

switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
  default:
    Console.WriteLine("Mellem 1 og 7 din skovl!");
    break;
}
Console.ReadLine();
#endregion


