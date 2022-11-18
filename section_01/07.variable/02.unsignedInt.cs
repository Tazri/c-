using System;

class ClassName{
    static void Main(){
        byte byteNumber = 33; // one byte (0 to 255)
        ushort ushortNumber = 343; // two byte (0 to 65,535)
        uint uintNumber = 354325642; // four byte (0 to 4,294,967,295)

        // append u in the last
        // uint uintNumber = 354325642U; // four byte (0 to 4,294,967,295)
        // uint uintNumber = 354325642u; // four byte (0 to 4,294,967,295)
        
        
        ulong ulongNumber = 39044563456; // eight byte (0 to 18,446,744,073,709,551,615)
        
        // append UL or ul in the last
        // ulong ulongNumber = 39044563456UL; 
        // ulong ulongNumber = 39044563456ul; 

        Console.WriteLine($"byteNumber : {byteNumber}");
        Console.WriteLine($"ushortNumber : {ushortNumber}");
        Console.WriteLine($"uintNumber : {uintNumber}");
        Console.WriteLine($"ulongNumber : {ulongNumber}");


    }
}

/*
output : 
ushortNumber : 343
uintNumber : 354325642
ulongNumber : 39044563456
*/