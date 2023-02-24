using System;

class TopN{
    static void print(int n){
        Console.WriteLine($"Top {n}");
    }
    static void Main(){

        int n = int.Parse(Console.ReadLine());

        if(n <= 1) print(1);
        else if(n <= 3) print(3);
        else if(n <= 5) print(5);
        else if(n <= 10) print(10);
        else if(n <= 25) print(25);
        else if(n <= 50) print(50);
        else if(n <= 100) print(100);
    }
}