using System;

class ClassName{
    static void Main(){
        int numberInt = 3045;
        object objectNumberInt = numberInt;

        // when unboxing thing cast it c style
        int unboxThingInt = (int) objectNumberInt; // c style cast 

        // below unbox is error, int only unbox as int because int boxing as int
        // float unboxThingFloat = (float) objectNumberInt;
        // double unboxThingDouble = (double) objectNumberInt;

        Console.WriteLine($"unboxThingInt : {unboxThingInt}");
    }
}

/*
output : 
unboxThingInt : 3045
*/