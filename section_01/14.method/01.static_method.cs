using System;

class DisplayClass{
    // public static method
    public static void display(string n){
        Console.WriteLine(n);
    }
}

class StaticMethod{
    // below a static method
    static void print(string s){
        Console.WriteLine(s);
    }
    static void Main(){
        print("Hello World! From Print");
        
        DisplayClass.display("Hello, Universe! From DisplayClass!!");

    }
}

/*
Hello World! From Print
Hello, Universe! From DisplayClass!!
*/