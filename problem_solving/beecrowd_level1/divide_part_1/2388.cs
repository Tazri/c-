using System;

class ProgramClass{
    static int getDistance(){
        string line = Console.ReadLine();
        string []words = line.Split(' ');

        int time = int.Parse(words[0]);
        int valocity = int.Parse(words[1]);
        return time*valocity;
    }
    static void Main(){
        int totalRecord = int.Parse(Console.ReadLine());
        int distance = 0;

        for(int i = 0;i < totalRecord;i++){
            distance += getDistance();
        }

        Console.WriteLine(distance);
    }
}