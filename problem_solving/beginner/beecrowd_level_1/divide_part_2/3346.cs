using System;

class GDPFluctuation{
    static void Main(){
        string line = Console.ReadLine();
        string []words = line.Split(' ');
        double fOne = double.Parse(words[0]);
        double fTwo = double.Parse(words[1]);

        double result = (fOne + 100) * (fTwo/100 + 1) - 100;

        Console.WriteLine("{0}",result.ToString("0.000000"));
    }
}