using System;

class ConvertClass{
    static void Main(){
        int num = 65;
        string stringFloat = "34.43";
        string stringInt = "343";

        // using Convert class for convert the thing
        char chNum = Convert.ToChar(num);
        double doubleNum = Convert.ToDouble(stringFloat);
        int intNum = Convert.ToInt32(stringInt);
        double doubleNumint = Convert.ToDouble(stringInt);
        short shortNum = Convert.ToInt16(stringInt);
        uint uintNum = Convert.ToUInt32(stringInt);

        Console.WriteLine($"chNum : {chNum}");
        Console.WriteLine($"doubleNum : {doubleNum}");
        Console.WriteLine($"intNum : {intNum}");
        Console.WriteLine($"doubleNumint : {doubleNumint}");
        Console.WriteLine($"shortNum : {shortNum}");
        Console.WriteLine($"uintNum : {uintNum}");
        Console.WriteLine($"Convert.ToInt32(\"-43\") : {Convert.ToInt32("-43")}");
    }
}

/*
chNum : A
doubleNum : 34.43
intNum : 343
doubleNumint : 343
shortNum : 343
uintNum : 343
Convert.ToInt32("-43") : -43
*/