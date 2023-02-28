using System;

class Encription{
    static char getChar(char c,int shift = 3){
        if((c >= 'A' && c <= 'Z')||
           (c >= 'a' && c <= 'z')){
            return Convert.ToChar((int)c + shift);
            }
        return c;
    }

    static char leftShift(char c){
        return Convert.ToChar((int) c - 1);
    }

    static string changing(string line){
        string changed = "";

        for(int i = 0;i < line.Length;i++){
            changed += getChar(line[i]);
        }

        return changed;
    }

    static string reversing(string line){
        string reversed = "";

        for(int i = line.Length -1;i >= 0;i--){
            reversed += line[i];
        }

        return reversed;
    }

    static string encript(string line){
        string changedLine = changing(line);
        string reversedLine = reversing(changedLine);
        string encripted = "";
        int indexHalf = reversedLine.Length /2;

        // first half
        for(int i = 0;i < indexHalf;i++){
            encripted += reversedLine[i];
        }

        // second half
        for(int j = indexHalf;j < reversedLine.Length;j++){
            encripted += leftShift(reversedLine[j]);
        }


        return encripted;
    }

    static void Main(){
        int totalTestCase = int.Parse(Console.ReadLine());
        

        for(int i = 0;i < totalTestCase;i++){
            string line = Console.ReadLine();
            Console.WriteLine(encript(line));
        }
    }
}