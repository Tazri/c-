using System;

class ProgramClass{
    static void Main(){
        string line = Console.ReadLine();
        string []words = line.Split(' ');

        double distance = double.Parse(words[0]);
        double diameterOne = double.Parse(words[1]);
        double diameterTwo = double.Parse(words[2]);

        double result = distance / (diameterOne+diameterTwo);

        Console.WriteLine("{0:0.00}",result);
    }
}