using System;

class ProgramClass{
    static void Main(){
        int totalNumber = int.Parse(Console.ReadLine());

        int change = 1; // think first is change;

        int lastValue = int.Parse(Console.ReadLine());
        for(int i =0;i < totalNumber-1;i++){
            int value = int.Parse(Console.ReadLine());

            if(lastValue != value){
                change++;
            }

            lastValue = value;
        }

        Console.WriteLine(change);
    }
}