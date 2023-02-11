using System;

class SaldoDoVovo{
    static void Main(){
        string line = Console.ReadLine();
        string []words = line.Split(' ');

        int totalTransition = int.Parse(words[0]);
        int balance = int.Parse(words[1]);
        int minimumState = balance;

        for(int i = 0; i < totalTransition;i++){
            int amount = int.Parse(Console.ReadLine());

            balance += amount;

            if(balance < minimumState){
                minimumState = balance;
            }
        }

        Console.WriteLine(minimumState);
    }
}