using System;


class LED{
    static int []numbers = new int[10]{
        6, // 0
        2, // 1
        5, // 2
        5, // 3
        4, // 4
        5, // 5
        6, // 6
        3, // 7
        7, // 8
        6  // 9

    };

    static int getLED(char l){
        if(l >= '0' && l <= '9'){
            return numbers[(int)(l - '0')];
        }

        return 0;
    }
    static void Main(){
        int testcase = int.Parse(Console.ReadLine());

        for(int i = 0;i < testcase;i++){
            string line = Console.ReadLine();
            int totalLEDS = 0;

            for(int j = 0;j < line.Length;j++){
                totalLEDS += getLED(line[j]);
            }

            Console.WriteLine($"{totalLEDS} leds");
        }
    }
}