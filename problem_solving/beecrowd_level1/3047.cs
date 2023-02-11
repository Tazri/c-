using System;

class Aidade{
    static int getYear(){
        return int.Parse(Console.ReadLine());
    }

    static void print(int n){
        Console.WriteLine(n);
    }
    static void Main(){
        int m = getYear();
        int a = getYear();
        int b = getYear();
        int c = m - a -b;

        if((a > b) && (a > c)){
            print(a);
        }else if((b>a) && (b > c)){
            print(b);
        }else{
            print(c);
        }
    }
}