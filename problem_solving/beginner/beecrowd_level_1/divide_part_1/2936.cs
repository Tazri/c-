using System;

class ProgramClass{
    static int []list = new int[5]{
        300,
        1500,
        600,
        1000,
        150
    };

    static int getGrams(int i,int n){
        return list[i]*n;
    }
    static void Main(){
        int totalGrams = 225; // dona alway take 225 grams

        for(int i = 0; i < 5;i++){
            int n = int.Parse(Console.ReadLine());

            totalGrams += getGrams(i,n);
        }

        Console.WriteLine(totalGrams);
    }
}