using System;

class Cops{
    static void swap(ref int a, ref int b){
        int temp = a;
        a = b;
        b = temp;
    }
    static void Main(){
        int totalTurn = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 0;
        int c = 0;

        string currentCop = Console.ReadLine();

        if(currentCop == "A"){
            a = 1;
        }else if(currentCop == "B"){
            b = 1;
        }else if(currentCop == "C"){
            c = 1;
        }

        // play the game
        for(int i = 0;i < totalTurn;i++){
            string command = Console.ReadLine();

            if(command == "1"){
                swap(ref a,ref b);
            }else if(command == "2"){
                swap(ref b,ref c);
            }else if(command == "3"){
                swap(ref a,ref c);
            }
        }

        if(a == 1){
            Console.WriteLine("A");
        }else if(b == 1){
            Console.WriteLine("B");
        }else if(c == 1){
            Console.WriteLine("C");
        }
    }
}