using System;

class ProgramClass{
    static void Main(){
        string line = Console.ReadLine();

        string[] words = line.Split('.');

        
        Console.Write(int.Parse(words[1]));
        Console.Write(".");
        Console.WriteLine(int.Parse(words[0]));
    }
}