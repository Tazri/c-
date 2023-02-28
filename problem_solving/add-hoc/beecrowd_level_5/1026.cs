using System;

class ToCarrayOrNotCarry{
    static void Main(){
        string line = Console.ReadLine();

        while(line != null){
            string []words = line.Split(' ');
            uint a = uint.Parse(words[0]);
            uint b = uint.Parse(words[1]);

            uint notAAndB = (~a) & b;
            uint aAndNotB = a & (~b);
            uint sum = notAAndB | aAndNotB;

            Console.WriteLine(sum);

            line = Console.ReadLine();
        }
    }
}