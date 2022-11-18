using System;

class ClassName{
    static void Main(){
        double doubleNumber = 3.454;
        double mantissaNumber = 3.3E2; // 
        double anotherDoubleNumber = 4.454e3;

        Console.WriteLine($"doubleNumber : {doubleNumber}");
        Console.WriteLine($"mantissaNumber : {mantissaNumber}");
        Console.WriteLine($"anotherDoubleNumber : {anotherDoubleNumber}");
    }
}

/*
output : 
doubleNumber : 3.454
mantissaNumber : 330
anotherDoubleNumber : 4454
*/