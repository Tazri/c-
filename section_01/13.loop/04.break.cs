using System;

class BreakClass{
    static void Main(){
        int i = 0;

        while(i++ < 10){
            if(i == 4) break;
            Console.WriteLine($"Hello, Mr. {i}");
        }
    }
}

/*
output : 
Hello, Mr. 1
Hello, Mr. 2
Hello, Mr. 3
*/