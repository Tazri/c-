using System;

class ObjectParams{
    static void Main(){
        Console.WriteLine("printObject(3,4,'a') : ");
        printObject(3,4,'a');

        Console.WriteLine("printObject(\"hello,\", \"World\") : ");
        printObject("hello","world");

        Console.WriteLine("printObject() : ");
        printObject();
    }

    // below object params
    static void printObject(params object []objectArray){
        foreach(object o in objectArray){
            Console.Write($"{o} ");
        }
        Console.WriteLine();
    }

}

/*
output : 
printObject(3,4,'a') : 
3 4 a 
printObject("hello,", "World") : 
hello world 
printObject() : 
*/