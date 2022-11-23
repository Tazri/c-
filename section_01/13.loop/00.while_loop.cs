using System;

class WhileLoop{
    static void Main(){
        int i = 0;

        while(i < 5){
            Console.WriteLine($"Hi Mr.{i++}");
        }
    }
}

/*
output : 
Hi Mr.0
Hi Mr.1
Hi Mr.2
Hi Mr.3
Hi Mr.4
*/