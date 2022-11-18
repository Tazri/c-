using System;

class ClassName{
    static void Main(){
        // use m or M at last position, required
        decimal decimalNumber = 3432.3M;
        decimal edecimalNumber = 343.34e2m; // mantiss e exponent

        Console.WriteLine($"decimalNumber : {decimalNumber}");
        Console.WriteLine($"edecimalNumber : {edecimalNumber}");
    }
}

/*
output : 
decimalNumber : 3432.3
edecimalNumber : 34334
*/