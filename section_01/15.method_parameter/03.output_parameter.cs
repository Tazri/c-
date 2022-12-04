using System;

class OutClass{
    static void Main(){
        int m;
        square(10,out m);

        Console.WriteLine($"m : {m}");
    }

    static void square(int x,out int m){
        m = x*x;
    }
}

/*
m : 100
*/