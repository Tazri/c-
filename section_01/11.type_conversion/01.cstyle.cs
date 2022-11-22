using System;

class CStyle{
    static void Main(){
        int num = 65;
        
        // c style type convertion
        uint uNum = (uint) num;
        char chNum = (char) num;
        decimal decimalNum = (decimal) num;
        double doubleNum = (double) num;
        float floatNum = (float) num;
        

        Console.WriteLine($"uNum : {uNum}");
        Console.WriteLine($"chNum : {chNum}");
        Console.WriteLine($"decimalNum : {decimalNum}");
        Console.WriteLine($"doubleNum : {doubleNum}");
        Console.WriteLine($"floatNum : {floatNum}");
    }
}

/*
output :
uNum : 65
chNum : A
decimalNum : 65
doubleNum : 65
floatNum : 65
*/