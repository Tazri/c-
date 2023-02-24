using System;

class ChristmasBalls{
    static void Main(){
        int ball = int.Parse(Console.ReadLine());
        int branch = int.Parse(Console.ReadLine());

        int requiredBall = branch / 2 ;
        int needBall = requiredBall - ball;

        if(needBall > 0){
            Console.WriteLine($"Faltam {needBall} bolinha(s)");
        }else{
            Console.WriteLine("Amelia tem todas bolinhas!");
        }
    }
}