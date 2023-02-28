using System;

class Fibo{
    static int totalCalled =0 ;

    static int fib(int n){
        totalCalled++;
        if(n == 0){
            return 0;
        }else if(n == 1){
            return 1;
        }

        return fib(n - 1) + fib(n-2);
    }
    static void Main(){
        int testCase = int.Parse(Console.ReadLine());

        for(int n = 1;n <= testCase;n++){
            int number = int.Parse(Console.ReadLine());
            int result = fib(number);

            Console.WriteLine($"fib({number}) = {totalCalled-1} calls = {result}");
            totalCalled = 0;
        }
    }
}