/*
Beecrowd dose not accept it
*/

using System;

class JustifiedLeft{
    static void printSpace(int n,char space=' '){
        for(int i = 0;i < n;i++){
            Console.Write(space);
        }
    }

    static string getLine(){
        string line = Console.ReadLine();
        string finalLine = "";
        string word = "";
        bool isWordStart = false;

        for(int i = 0;i < line.Length;i++){
            char c = line[i];
            if(isWordStart){
                if(c == ' '){
                    isWordStart = false;

                    if(finalLine == ""){
                        finalLine = word;
                    }else{
                        finalLine += " " + word;
                    }

                    word = "";
                }else{
                    word += c;
                }
            }else{
                if(c != ' '){
                    isWordStart = true;
                    word += c;
                }
            }
        }

        if(finalLine == ""){
            finalLine = word;
        }else{
            if(word != ""){
                finalLine += " " + word;
            }
        }

        return finalLine;
    }

    static void Main(){
        int totalLine = int.Parse(Console.ReadLine());

        while(totalLine > 0){
            string [] lineList = new string[totalLine];
            
            // get first one
            lineList[0] = getLine();
            int maxLen = lineList[0].Length;

            for(int i = 1; i < totalLine;i++){
                lineList[i] = getLine();

                if(lineList[i].Length > maxLen){
                    maxLen = lineList[i].Length;
                }
            }

            foreach(string line in lineList){
                int needSpace = maxLen - line.Length;

                printSpace(needSpace);
                Console.WriteLine(line);
            }

            Console.WriteLine();
            totalLine = int.Parse(Console.ReadLine());
        }
    }
}