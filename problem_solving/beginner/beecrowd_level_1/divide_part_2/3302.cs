using System;

class CorrectAnswer{
    static void Main(){
        int total_input = int.Parse(Console.ReadLine());

        for(int i = 1; i <= total_input; i++){
            string n = Console.ReadLine();

            Console.WriteLine($"resposta {i}: {n}");
        }
    }
}