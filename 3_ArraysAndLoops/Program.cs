#region Assignment
/*
* Array, List and loops are essential tools for every programmer
* Todays work will be taking your own notes in this file
* Alter the examples so you better understand them
* Create new examples which you can use in the future
*
* Before you run the program, try to see if you can guess 
* what is written in the console via Line 68 in this file (the foreach loop)
*/
#endregion
#region Arrays
string[] stringArr = new string[2];
Console.WriteLine("Length of string array is = " + stringArr.Length);
stringArr[0] = "I'm the first string in the array";
stringArr[1] = "I'm the second string in the array";
stringArr[1] = "The first string have now been changed to this!";
//Console.WriteLine(stringArr[1]);
//Array.Resize(ref stringArr, 10);


int[] intArr = new int[5];
intArr[0] = 0;
intArr[1] = 1;
intArr[2] = 321;
//Console.WriteLine(intArr[2]);

bool[] boolArr = new bool[intArr.Length + stringArr.Length];
//Console.WriteLine("Length of Bool array : " + boolArr.Length);

#endregion

#region Lists, a dynamic sized array

List<string> stringList = new List<string>();
stringList.Add("This is the first string");
stringList.Add("Second string");
stringList.Add("Third string");

stringList.Remove("This is the first string");

int index = stringList.IndexOf("Second string");
stringList[index] = "I changed the second string";

//Console.WriteLine(stringList[0]);

#endregion

#region Loops

List<int> numbers = new List<int>();
int counter = 0;
while(counter < 10){
    numbers.Add(counter);
    counter++;
}

do{
    numbers[--counter]++;
}while(counter > 0);


for(int i = 0; i < 10; i++){
    numbers[i] += 1;
}

foreach(int number in numbers){
    Console.WriteLine(number);
}


//Loops can be nested
for(int x = 0; x < 5; x++){
    for(int y = 0; y < 5; y++){
        Console.WriteLine("(" + x + ", " + y + ")");
    }
}

//Loops can also make use of break/continue
int infiniteCounter = 10;
while(true){
    infiniteCounter--;
    if(infiniteCounter%2 == 0){ //Modulo 2 to only print even numbers
        Console.WriteLine(infiniteCounter);
    }else{
        continue; //Go to next iteration of the while-loop
    }
    if(infiniteCounter < 0){
        break; //Break out of while-loop
    }
}

#endregion
