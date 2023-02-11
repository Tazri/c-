using System;

class ProgramClass{
    static void Main(string[] args){
        string line = Console.ReadLine();

        // traverse the string
        for(int i = 0;i < line.Length;i++){
            char c = line[i];

            if(c == '.' || c == '-'){
                Console.WriteLine();
                continue;
            }

            Console.Write(c);
        }

        Console.WriteLine();
    }
}