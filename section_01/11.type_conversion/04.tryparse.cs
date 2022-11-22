using System;

class ClassParse{
    static void Main(){
        int num;

        if (int.TryParse("44",out num)){
            Console.WriteLine($"num : {num}");
        }

        if (int.TryParse("34.33",out num)){
            Console.WriteLine($"num : {num}");
        }
    }
}

/*
output : 
num : 44
*/