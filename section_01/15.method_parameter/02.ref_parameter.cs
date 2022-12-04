using System;

class RefClass{
    static void Main(){
        int a = 19, b = 23;

        Console.WriteLine("> Before Swaping <");
        display(a,b);

        swap(ref a,ref b);

        Console.WriteLine("> After Swaping <");
        display(a,b);
    }

    static void display(int a,int b){
        Console.WriteLine($"> a = {a}");
        Console.WriteLine($"> b = {b}");
    }

    static void swap(ref int a,ref int b){
        a = a*b;
        b = a/b;
        a = a/b;
    }
}

/*
> Before Swaping <
> a = 19
> b = 23
> After Swaping <
> a = 23
> b = 19
*/