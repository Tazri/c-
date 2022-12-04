using System;

class ObjectClass{
    static void displayArray(object[] objectArray){
        int length = objectArray.Length;
        int i = 0;

        Console.Write($"{objectArray}({length})[{{");

        for(;i < length - 1;i++){
            Console.Write($"{objectArray[i]},");
        }
        Console.WriteLine($"{objectArray[i]}}}");
    }

    static void Main(){
        object [] objectArr = {3,34,'a',"hello"};

        displayArray(objectArr);
    }
}