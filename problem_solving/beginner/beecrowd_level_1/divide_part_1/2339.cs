using System;

class AvioesDePapel{
    static void Main(){
       string line = Console.ReadLine();
       string []words = line.Split(' ');

       int c = int.Parse(words[0]);
       int p = int.Parse(words[1]);
       int f = int.Parse(words[2]);

        if((c*f) <= p){
            Console.WriteLine("S");
        }else{
            Console.WriteLine("N");
        }
    }
}