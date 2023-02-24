using System;

class ElevatorTrouble{
    static int getInt(string n){
        return int.Parse(n);
    }

    static int is_possible(int floor,int stage,int target,int up, int down){ // return -1 if it is not possible
        // if target is stage
        if(stage == target){
            return 0;
        }

        // if up is 0
        if(up == 0){
            return -1;
        }

        // the floor stack
        int floorStack = target - stage;
        int totalPress = floorStack / up;

        if(floorStack % up == 0){
            return totalPress;
        }

        if(up == down){
            return -1;
        }

        

        int currentStage = stage + (totalPress*up);

        // now changing current stage to target by 1 down 

        while(currentStage >= floor){
            currentStage -= down;

            if(currentStage < floor){
                return -1;
            }

            totalPress++; // for pressing down

            // check is up press to go target 
            floorStack = target - currentStage;

            if(floorStack % up == 0){ // then it is possible to go target
                totalPress += (floorStack / up);
                return totalPress;
            }
        }

        return -1;
    }

    static void Main(){
        string line = Console.ReadLine();
        string []words = line.Split(' ');

        // extract all data 
        int floor  = getInt(words[0]); // f
        int stage = getInt(words[1]); // s
        int target = getInt(words[2]); // g
        int up = getInt(words[3]); // u
        int down = getInt(words[4]); // d
        int totalPress = 0;
        int temp = 0; // for store temporary data

        // make everything up 
        if(target < stage){
            temp = stage;
            stage = target;
            stage = temp;

            // change up and down
            temp = up;
            up = down;
            down = temp;
        }

        totalPress = is_possible(floor,stage,target,up,down);

        if(totalPress == -1){
            Console.WriteLine("use the stairs");
        }else{
            Console.WriteLine(totalPress);
        }
        
    }
}