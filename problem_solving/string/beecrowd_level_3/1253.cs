using System;


class CaesarCipher{
    static char deshift(char c,int n){
        int index = (int)c - (int)'A' + 1;
        int shiftIndex = index - n;

        if(shiftIndex < 1){
            shiftIndex = 26 + shiftIndex;
        }

        char ch = (char) ('A' + (char)(shiftIndex - 1));

        return ch;
    }
    static void Main(){
        int testCase = int.Parse(Console.ReadLine());

        for(int i = 0;i < testCase;i++){
            string line = Console.ReadLine();
            int deshiftNumber = int.Parse(Console.ReadLine());

            for(int j = 0;j < line.Length;j++){
                Console.Write(deshift(line[j],deshiftNumber));
            }

            Console.WriteLine();
        }
    }
}