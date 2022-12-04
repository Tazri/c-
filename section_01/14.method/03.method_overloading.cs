using System;

class MethodOverloading{
    static int volume(int baseSize){ // for cube
        return baseSize*baseSize*baseSize;
    }

    static double volume(double height,double baseSize){// for triangle
        return 0.5*height*baseSize;
    }

    static void Main(){
        Console.WriteLine($"volume(10) : {volume(10)}");
        Console.WriteLine($"volume(10,20) : {volume(10,20)}");

    }
}

/*
output : 
volume(10) : 10000
volume(10,20) : 100
*/