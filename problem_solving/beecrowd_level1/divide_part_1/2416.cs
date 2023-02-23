using System;

class Corrida{
    static void Main(){
        string line = Console.ReadLine();
        string []words = line.Split(' ');

        int a = int.Parse(words[0]);
        int b = int.Parse(words[1]);
        Console.WriteLine(a%b);
    }
}