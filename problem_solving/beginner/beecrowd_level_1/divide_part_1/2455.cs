using System;

class Gangorra{
    static void Main(){
        string line = Console.ReadLine();
        string []words = line.Split(' ');

        int p1 = int.Parse(words[0]);
        int c1 = int.Parse(words[1]);
        int p2 = int.Parse(words[2]);
        int c2 = int.Parse(words[3]);

        int firstValue = p1*c1;
        int secondValue = p2*c2;

        if(firstValue == secondValue){
            Console.WriteLine(0);
        }else if(firstValue < secondValue){
            Console.WriteLine(1);
        }else{
            Console.WriteLine(-1);
        }
    }
}