using System;

class Program{
    static void Main(){
        string line = Console.ReadLine();

        int position = 1;

        for(int i = 0;i < line.Length;i++){
            if(line[i] == '1')
                break;
            
            if(line[i] == '0')
                position++;
        }

        Console.WriteLine(position);
    }
}