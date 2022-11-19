using System;

class ClassName{
    static void Main(){
        int number = 1000;
        object objectNumber = number; // create objectNumber and assign number

        Console.WriteLine($"number : {number}");
        Console.WriteLine($"objectNumber : {objectNumber}");

        number = 20;
        Console.WriteLine("\n\nAfter changing number 1000 to 20 : ");
        Console.WriteLine($"number : {number}");
        Console.WriteLine($"objectNumber : {objectNumber}");

        objectNumber = 34;
        Console.WriteLine("\n\nafter changing object number to 34");
        Console.WriteLine($"number : {number}");
        Console.WriteLine($"objectNumber : {objectNumber}");

    }
}

/*
output :
number : 1000
objectNumber : 1000


After changing number 1000 to 20 : 
number : 20
objectNumber : 1000


after changing object number to 34
number : 20
objectNumber : 34
*/