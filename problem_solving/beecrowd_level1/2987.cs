using System;

class ProgramClass{
    static void Main(){
        char c = Convert.ToChar(Console.ReadLine());

        Console.WriteLine((int)((c-'A')+1));
    }
}