using System;

class TextNumber{
    static void Main(){
        Console.Write("Enter num 1 to 3 :");

        int num = int.Parse(Console.ReadLine());

        // print text
        switch(num){
            case 0 : 
                Console.WriteLine("Zero");
                break;
            case 1 : 
                Console.WriteLine("One");
                break;
            case 2 : 
                Console.WriteLine("Three");
                break;
            default :
                Console.WriteLine("I don't know Number :(");
                break;
        }
    }
}

/*
output : 
Enter num 1 to 3 :2
Three
*/