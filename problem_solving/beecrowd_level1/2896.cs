using System;

class ProgramClass{
    static int []getNumbers(){
        string line = Console.ReadLine();
        string []words = line.Split(' ');

        return new int[2]{int.Parse(words[0]),int.Parse(words[1])};
    }
    static void Main(){
        int testCase = int.Parse(Console.ReadLine());

        while((testCase--) > 0){
            int []numbers = getNumbers();
            
            int bottolRemain = 0;

            int bought = numbers[0];
            int need = numbers[1];

            bottolRemain += (int)(bought/need);
            bottolRemain += (bought%need);

            Console.WriteLine(bottolRemain);

        }
    }
}