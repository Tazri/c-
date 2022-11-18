using System;

class ClassName{
    static void Main(){
        // float must be append f or F
        float floatNumber = 343.33f; // 4 bytes (1.5x10^-45 to 3.4x10^35)
        // float floatNumber = 343.33F; // same as above just use F

        // use d or D is optional at last position
        double doubleNumber = 343.33; // 8 bytes (5.0x10^-324 to 1.7^308)
        // double doubleNumber = 343.33d;
        // double doubleNumber = 343.33D;


        // mantissa e exponent
        float efloatNumber = 3.4e3f;
        double edoubleNumber = 4.5e-4;

        Console.WriteLine($"floatNumber : {floatNumber}");
        Console.WriteLine($"doubleNumber : {doubleNumber}");
        Console.WriteLine($"efloatNumber : {efloatNumber}");
        Console.WriteLine($"edoubleNumebr : {edoubleNumber}");
    }
}

/*
output : 
floatNumber : 343.33
doubleNumber : 343.33
efloatNumber : 3400
edoubleNumebr : 0.00045
*/