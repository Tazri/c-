using System;

class ClassParse{
    static void Main(){
        int num = int.Parse("345");
        // int num = int.Parse("345.33"); // throw error

        Console.WriteLine($"num : {num}");
    }
}

/*
output : 
num : 345
*/