using System;

class Keanu{
    static void Main(){
        int number = int.Parse(Console.ReadLine());
        int white = 0,black = 0;
        int total_cell = number * number;

        // if number is even
        if(number % 2 == 0){
            white = total_cell /2;
            black = total_cell / 2;
        }else{
            white = (total_cell / 2 ) + 1;
            black = total_cell / 2;
        }

        Console.WriteLine($"{white} casas brancas e {black} casas pretas");
    }
}