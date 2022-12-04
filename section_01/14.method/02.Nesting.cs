using System;


class MainClass{
    static void Main(){
        MainClass o = new MainClass();

        Console.WriteLine($"o.large(3,5) : {large(3,5)}");
    }
    
    public  
    int large(int a,int b){
        return max(a,b);
    }

    private int max(int a,int b){
        if(a >b)return a;
        else return b;
    }

}