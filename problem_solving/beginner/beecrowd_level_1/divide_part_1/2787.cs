using System;

class Program{
    static void Main(){
        const int black = 0;
        const int white = 1;

        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int lastRowFirstCell = rows % 2 == 0 ? black : white;

        int lowerRightCell = lastRowFirstCell;

        if(cols % 2 == 0){
            lowerRightCell = lastRowFirstCell == 1 ? 0 : 1;
        }

        Console.WriteLine(lowerRightCell);
    }
}