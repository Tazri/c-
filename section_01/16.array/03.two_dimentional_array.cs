using System;

class TwoDimentionalArray{
    static void showTable(int [,] table,int row,int col){
        Console.WriteLine($"{table} : ");
        int rowTrack,colTrack ;

        for(rowTrack = 0;rowTrack < row; rowTrack++){
            Console.Write("{");
            for(colTrack = 0;colTrack < (col - 1);colTrack++){
                Console.Write($"{table[rowTrack,colTrack]},");
            }

            Console.WriteLine(($"{table[rowTrack,colTrack]}}}"));
        }
    }

    static void Main(){
        // create two dimentional array
        int [,] tableOne = new int[2,2];

        // initialize 
        tableOne[0,0] = 99;
        tableOne[1,1] = 33;

        showTable(tableOne,2,2);

        // initialize and declare at a time
        int [,] tableTwo = new int[3,3]{
            {3,4,2},
            {2,2,3},
            {3,5,4}
        };

        showTable(tableTwo,3,3);

        // another way
        int [,] tableThree = {
            {3,3},
            {32,11},
            {2,2}
        };

        showTable(tableThree,3,2);
    }
}

/*
output : 
System.Int32[,] : 
{99,0}
{0,33}
System.Int32[,] : 
{3,4,2}
{2,2,3}
{3,5,4}
System.Int32[,] : 
{3,3}
{32,11}
{2,2}
*/