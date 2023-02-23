using System;

class ProgramClass{
    static void Main(){
        uint d = uint.Parse(Console.ReadLine()); // distance

        if(d <= 800){
            Console.WriteLine(1);
        }else if(d <= 1400){
            Console.WriteLine(2);
        }else if(d <= 20000){
            Console.WriteLine(3);
        }
    }
}