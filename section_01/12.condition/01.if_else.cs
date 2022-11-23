using System;

class IfElseClass{
    static void Main(){
        int num;

        Console.Write("Enter num : ");
        string input = Console.ReadLine();

        if(int.TryParse(input,out num)){
            if(num % 2 == 0){
                Console.WriteLine($"{num} is EVEN.");
            }else{
                Console.WriteLine($"{num} is ODD.");
            }
        }else{
            Console.WriteLine("> Please Enter Correctly <");
        }
    }
}

/*
Enter num : 454
454 is EVEN.
*/