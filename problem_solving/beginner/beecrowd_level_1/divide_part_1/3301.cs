using System;

class MiddleNepew{
    static string NameZ = "zezinho";
    static string NameL = "luisinho";
    static string NameH = "huguinho";

    static public void print(string s){
        Console.WriteLine(s);
    }

    
    static void Main(){
        string line = Console.ReadLine();
        string [] word = line.Split(' ');

        int h = int.Parse(word[0]);
        int z = int.Parse(word[1]);
        int l = int.Parse(word[2]);

        // check it is z second biggest
        if((h > z) && ( z > l) ||
           (l > z) && ( z > h)){
            print(NameZ);
        }else if((h > l) && ( l > z) ||
           (z > l) && ( l > h)){
            print(NameL);
        }else{
            print(NameH);
        }

        
    }
}