using System;

class TheChristmasTree{
    static void Main(){
        int testcase = int.Parse(Console.ReadLine());

        while(testcase > 0){
            string line = Console.ReadLine();
            string []words = line.Split(' ');

            int height = int.Parse(words[0]);
            int diameters = int.Parse(words[1]);
            int branches = int.Parse(words[2]);

            // requirement analysis
            if(height >= 200 && 
               height <= 300 &&
               diameters >= 50 &&
               branches >= 150){
                Console.WriteLine("Sim");
            }else{
                Console.WriteLine("Nao");
            }
            testcase--;
        }
    }
}