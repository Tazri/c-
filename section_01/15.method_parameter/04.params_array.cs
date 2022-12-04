using System;

class ParameterArray{
    static void displayInt(params int []intArray){
        foreach( int i in intArray){
            Console.WriteLine($"{i}");
        }
    }

    static void Main(){
        int [] intArray = {3,4,5,2,1};

        Console.WriteLine("displayInt(intArray) : ");
        displayInt(intArray);

        Console.WriteLine("displayInt(4,3,2,4) : ");
        displayInt(4,3,2,4);

        Console.WriteLine("displayInt() :");
        displayInt();
    }
}

/*
displayInt(intArray) : 
3
4
5
2
1
displayInt(4,3,2,4) : 
4
3
2
4
displayInt() :
*/