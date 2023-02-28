using System;

class LetterFrequency{
    static int getIndex(char c){
        if(c >= 'A' && c <= 'Z'){
            return c - 'A';
        }else if(c >= 'a' && c <= 'z'){
            return c - 'a';
        }

        return -1;
    }

    static void print(int i){
        Console.Write((char)('a' + i));
    }
    static void Main(){
        int testcase = int.Parse(Console.ReadLine());
        for(int p = 0;p < testcase;p++){
            string line = Console.ReadLine();
            int []indexMap = new int[26];
            int maxed = 0;

            for(int i = 0;i < line.Length;i++){
                // get character index
                int index =  getIndex(line[i]);

                if(index == -1){
                    continue;
                }

                indexMap[index]++;

                if(indexMap[index] > maxed){
                    maxed = indexMap[index];
                }
            }

            // printing 
            for(int i = 0;i < 26;i++){
                if(indexMap[i] == maxed){
                    print(i);
                }
            }
            Console.WriteLine();
        }
    }
}