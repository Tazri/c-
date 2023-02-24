using System;

class JustifiedLeft{
    static string readline(){
        return Console.ReadLine();
    }

    static string getTrimLine(){
        string line = readline();
        string trimLine = "";
        string words = "";
        bool isStart = false;

        for(int i = 0;i ){
            
        }
    }

    static void Main(){
        string line = getTrimLine();

        Console.WriteLine($"Here is trimmed Line >{line}<");
    }
}

/*
     ROMEO      AND
      JULIET WERE  
        IN LOVE 

3
hello   afdaljd    afe      
dajdfk  alfkje   afdlk   afe  afee 
afjlaek      
hello afdaljd afe
dajdfk alfkje afdlk afe afee
afjlaek


*/