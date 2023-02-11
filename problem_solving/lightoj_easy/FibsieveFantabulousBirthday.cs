using System;

class Program{
    static int [] getPoint(int target){
        int x = 1,y = 1;
        int number = 1;

        int cx = 2,cy=2; // corner x and y
        while(number < target){
            // checking for x
            y = cy;
            x = 1;
            while(x <= cx){
                number++;
                if(number == target){
                    return new int[]{x,y};
                }
                x++;
            }

            // checking y
            x = cx;
            y = cy-1; // becuase upper loop already check cx and cy
            while(y >= 1){
                number++;
                if(number==target){
                    return new int[]{x,y};
                }
                y--;
            }

            cx++;
            cy++;
        }

        return new int[]{x,y};

    }
    static void Main(){
        int cases = int.Parse(Console.ReadLine());
        
        for(int i =1;i<= cases;i++){
            int size = int.Parse(Console.ReadLine());
            int []Point = getPoint(size);

            Console.WriteLine($"Case {i}: {Point[1]} {Point[0]}");
        }
    }
}