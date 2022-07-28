#region Conditions; if, else if, else

if(2 > 5)
{
    Console.WriteLine("2 was bigger than 5");
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
    if(2*2 == 5){
        Console.WriteLine("2 times 2 is 5");    
    }
    //else if(...)

    Console.WriteLine("Conditions are easy!");
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

int day = 4;
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
}
#endregion