using System;

class ChangeValue{
    static void changeValue(int y){
        y += 43;
    }

    static void Main(){
        int x = 3;
        changeValue(x);
        Console.WriteLine($"x : {x}");
    }

}
