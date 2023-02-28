using System;

class Combiner{
    static void print(char c){
        Console.Write(c);
    }
    static void Main(){
        int testcase = int.Parse(Console.ReadLine());

        for(int i = 0;i < testcase;i++){
            string line = Console.ReadLine();
            string []words = line.Split();
            string wordsOne = words[0]; // indexing by j
            string wordsTwo = words[1]; // indexing by k
            int i1,i2;

            for(i1 = 0,i2 = 0;i1 <wordsOne.Length && i2 < wordsTwo.Length;i1++,i2++){
                print(wordsOne[i1]);
                print(wordsTwo[i2]);
            }

            if(wordsOne.Length != wordsTwo.Length){
                if(wordsOne.Length > wordsTwo.Length){
                    for(;i1 < wordsOne.Length;i1++){
                        print(wordsOne[i1]);
                    }
                }else{
                    for(;i2 < wordsTwo.Length;i2++){
                        print(wordsTwo[i2]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}