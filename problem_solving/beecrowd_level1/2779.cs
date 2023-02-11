using System;

class ProgramClass{
    static void Main(){
        uint totalSpace = uint.Parse(Console.ReadLine());
        uint totalCards = uint.Parse(Console.ReadLine());

        bool []album = new bool[totalSpace];

        for(int i = 0;i < totalSpace;i++){
            album[i] = false;
        }

        uint spaceLeft = totalSpace;

        for(int i = 0;i < totalCards;i++){
            int index = int.Parse(Console.ReadLine());

            if(!album[index-1]){
                album[index-1] = true;
                spaceLeft--;
            }
        }
        
        Console.WriteLine(spaceLeft);
    }
}