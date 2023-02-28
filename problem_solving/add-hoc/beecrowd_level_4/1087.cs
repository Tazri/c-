using System;

class Queen{
    static int diff(int n1,int n2){
        return n1 > n2 ? n1 - n2 : n2 - n1;
    }

    static void print(int n){
        Console.WriteLine(n);
    }
    static void Main(){
        string line = Console.ReadLine();

        while(true){
            string []words = line.Split();

            int x1 = int.Parse(words[0]);
            int y1 = int.Parse(words[1]);
            int x2 = int.Parse(words[2]);
            int y2 = int.Parse(words[3]);
            
            // break point
            if((x1 == 0) && (y1 == 0) && (x2 == 0) && (y2 == 0)){
                break;
            }

            if(x1 == x2 && y1 == y2){ // is same square
                print(0);
            }else if( x1 == x2 || y1 == y2){ // check vertically and horizontally
                print(1);
            }else if(diff(x1,x2) == diff(y1,y2)){ // check diagnal
                print(1);
            }else{
                print(2);
            }

            line = Console.ReadLine();
        }
    }
}