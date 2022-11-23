using System;

class ClassContinue{
    static void Main(){
        int i = 0;

        for(; i < 10;i++){
            if((i & 1) == 1) continue; // skip if it odd
            Console.WriteLine($"Hello, Mr. {i}");
        }
    }
}

/*
output : 
Hello, Mr. 0
Hello, Mr. 2
Hello, Mr. 4
Hello, Mr. 6
Hello, Mr. 8
*/