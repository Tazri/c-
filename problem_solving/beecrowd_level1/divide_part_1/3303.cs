using System;


class BigWord{
    static void Main(){
        // get input
        string word = Console.ReadLine();

        if(word.Length >= 10){
            Console.WriteLine("palavrao");
        }else{
            Console.WriteLine("palavrinha");
        }
    }
}