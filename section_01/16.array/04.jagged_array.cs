using System;

class JaggedArray{
    static void printArray(int[][] table){
        int row = table.Length;
        int rowTrack,colTrack;

        Console.WriteLine(table);
        for(rowTrack = 0;rowTrack < row;rowTrack++){
            Console.Write("{");
            for(colTrack = 0;colTrack < table[rowTrack].Length - 1; colTrack++){
                Console.Write($"{table[rowTrack][colTrack]},");
            }
            Console.WriteLine($"{table[rowTrack][colTrack]}}}");
        }
    }

    static void Main(){
        // create jagged array
        int [][] table = new int[3][];
        table[0] = new int[]{3,4,5};
        table[1] = new int[]{3,4,5,5};
        table[2] = new int[]{4,3,2};

        printArray(table);


    }
}