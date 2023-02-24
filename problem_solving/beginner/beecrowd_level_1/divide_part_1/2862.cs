using System;

class ProgramClass{
    static void print(int n){
        if(n <= 8000){
            Console.WriteLine("Inseto!");
        }else{
            Console.WriteLine("Mais de 8000!");
        }
    }

    static void Main(){
        int n = int.Parse(Console.ReadLine());

        for(int i =0;i < n;i++){
            int number = int.Parse(Console.ReadLine());
            print(number);
        }
    }
}