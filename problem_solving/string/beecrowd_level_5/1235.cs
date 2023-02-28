using System;

class InsideOut{
    static void Main(){
        int testcase = int.Parse(Console.ReadLine());

        for(int p = 0;p < testcase;p++){
            string line = Console.ReadLine();

            // print first half
            int secondIndex = line.Length / 2;

            for(int i = secondIndex-1;i >= 0;i--){
                Console.Write(line[i]);
            }

            // print second half
            for(int i = line.Length-1; i >= secondIndex;i--){
                Console.Write(line[i]);
            }

            Console.WriteLine();
        }
    }
}