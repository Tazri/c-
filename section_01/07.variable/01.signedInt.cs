using System;

class ClassName{
    static void Main(){
        sbyte sbyteNumber = 3; // one byte (-128 to 127)
        short shortNumber = 454; // two byte (-32,768 to 32,767)
        
        int intNumber = 3432; // four byte (-2,147,483,648 to 2,147,483,647)
        long longNumber = 3452354; // eight byte (-9,223,372,036,854,775,807 to 9,223,372,036,854,775,807,807) 
        
        // below all defination is right
        // long longNumber = 3452354l; // it throw warning because l are 1 look like same
        // long longNumber = 3452354L;  

        Console.WriteLine($"sbyteNumber : {sbyteNumber}");
        Console.WriteLine($"shortNumber : {shortNumber}");
        Console.WriteLine($"intNumber : {intNumber}");
        Console.WriteLine($"longNumber : {longNumber}");


    }
}

/*
output : 
sbyteNumber : 3
shortNumber : 454
intNumber : 3432
longNumber : 3452354
*/