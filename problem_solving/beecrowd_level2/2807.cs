using System;

class ProgramClass{
        static int []makeFibo(int n){
        if(n == 1){
            return new int[1]{1};
        }else if(n == 2){
            return new int[2]{1,1};
        }

        // else
        int []fib = new int[n];
        fib[0] = 1;
        fib[1] = 1;

        for(int i = 2;i < n;i++){
            fib[i] = fib[i-1]+fib[i-2];
        }

        return fib;
    }
    static void Main(){
        int size = int.Parse(Console.ReadLine());

        if(size == 1){
            Console.WriteLine("1");
        }else if(size == 2){
            Console.WriteLine("1 1");
        }else{
            // else
            int []fib = makeFibo(size);

            for(int i = size-1;i > 0;i--){
                Console.Write($"{fib[i]} ");
            }

            Console.WriteLine($"{fib[0]}");
        }
    }
}