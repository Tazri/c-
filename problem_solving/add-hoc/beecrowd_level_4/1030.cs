using System;

class Flavious{
    static int remain(int n,int k){
        int left = 0;

        for(int i = 1;i <= n;i++){
            left = (left+k) % i;
        }

        return left + 1;
    }

    static void Main(){
        int testcase = int.Parse(Console.ReadLine());

        for(int i = 1;i <= testcase;i++){
            string line = Console.ReadLine();
            string []words = line.Split();
            int n = int.Parse(words[0]);
            int k = int.Parse(words[1]);
            Console.WriteLine($"Case {i}: {remain(n,k)}");
        }
    }
}