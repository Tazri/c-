using System;

class ClassName{
    static void Main(){
        string firstName = "Mr.";
        string lastName = "Alayth";
        string fullName = $"{firstName} {lastName}!";

        Console.WriteLine($"Hello, {firstName} {lastName}");
        Console.WriteLine(fullName);
    }
}

/*
output : 
Hello, Mr. Alayth
Mr. Alayth!
*/