using System;

class DancingSentence{
    static char upper(char c){
        if(c >= 'A' && c <= 'Z'){
            return c;
        }else if(c >= 'a' && c <= 'z'){
            return (char) ('A' + (char) (c - 'a'));
        }

        return c;
    }

    static char lower(char c){
        if(c >= 'a' && c <= 'b'){
            return c;
        }else if(c >= 'A' && c <= 'Z'){
            return (char) ('a' + (char) (c - 'A'));
        }

        return c;
    }

    static bool isLetter(char c){
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
    }

    static void Main(){
        string line = Console.ReadLine();

        while(line != null){
            bool status = true;

            for(int i = 0;i < line.Length;i++){
                if(isLetter(line[i])){
                    if(status){
                        Console.Write(upper(line[i]));
                        status = !status;
                    }else{
                        Console.Write(lower(line[i]));
                        status = !status;
                    }
                }else{
                    Console.Write(line[i]);
                }
            }

            Console.WriteLine();

            line = Console.ReadLine();
        } 
    }
}