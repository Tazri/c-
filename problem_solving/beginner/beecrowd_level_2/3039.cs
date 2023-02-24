using System;

class SantasToy{
    static bool isMale(){
        string line = Console.ReadLine();
        string []words = line.Split(' ');

        if(words[1] == "F"){
            return false;
        }

        return true;
    }
    static void Main(){
        int totalToy = int.Parse(Console.ReadLine());

        int car = 0;
        int doll = 0;

        for(int i = 0;i < totalToy; i++){
            if(isMale()){
                car++;
            }else{
                doll++;
            }
        }

        // print result 
        Console.WriteLine($"{car} carrinhos");
        Console.WriteLine($"{doll} bonecas");
    }
}