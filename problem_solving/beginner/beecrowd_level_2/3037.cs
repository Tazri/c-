using System;

class PlayingDartsByDistance{
    static int getScore(){
        string line = Console.ReadLine();
        string []words = line.Split(' ');
        int x = int.Parse(words[0]);
        int d = int.Parse(words[1]);

        return x*d;
    }
    static void Main(){
        int testCase = int.Parse(Console.ReadLine());

        for(int i = 0;i < testCase;i++){
            // playing
            int johnScore = 0;
            int maryScore = 0;

            // john score
            for(int j = 0;j < 3;j++){
                johnScore += getScore();
            }

            for(int j = 0;j < 3;j++){
                maryScore += getScore();
            }

            if(maryScore > johnScore){
                Console.WriteLine("MARIA");
            }else{
                Console.WriteLine("JOAO");
            }
        }
    }
}