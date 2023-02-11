using System;

class ProgramClass{
    static void Main(){
        int totalLuck= 0;

        int testCase = int.Parse(Console.ReadLine());

        while((testCase--) > 0){
            int choose = int.Parse(Console.ReadLine());

            if(choose != 1)
                totalLuck++;
        }

        Console.WriteLine(totalLuck);
    }
}