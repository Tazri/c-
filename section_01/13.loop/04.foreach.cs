using System;

class ForeachLoop{
    static void Main(){
        string word = "hell";

        foreach(char ch in word){
            Console.WriteLine($"ch {ch}");
        }
    }
}

/*
output : 
ch h
ch e
ch l
ch l
*/