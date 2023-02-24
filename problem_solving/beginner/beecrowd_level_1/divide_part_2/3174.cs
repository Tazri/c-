using System;

class NoelsWorkGroup{
    static string dolls = "bonecos"; // 8 hours
    static string archeticts = "arquitetos"; // 4 hours
    static string musicians = "musicos"; // 6 hours
    static string drawners = "desenhistas"; // 12 hours

    static void Main(){
        int dollsHours = 0; // 8 hours
        int archetictsHours = 0; // 4 hours
        int musiciansHours = 0; // 6 hours
        int drawnersHours = 0; // 12 hours
        int totalToy = 0;

        int totalWorker = int.Parse(Console.ReadLine());

        // get hours
        for(int i = 0;i < totalWorker;i++){
            string line = Console.ReadLine();
            string []words = line.Split(' ');
            string groupName = words[1];

            if(groupName == dolls){
                dollsHours += int.Parse(words[2]);
            }else if(groupName == archeticts){
                archetictsHours += int.Parse(words[2]);
            }else if(groupName == musicians){
                musiciansHours += int.Parse(words[2]);
            }else if(groupName == drawners){
                drawnersHours += int.Parse(words[2]);
            }

        }

        totalToy += (dollsHours / 8);
        totalToy += (archetictsHours / 4);
        totalToy += (musiciansHours / 6);
        totalToy += (drawnersHours / 12);

        //finally print output :)
        Console.WriteLine(totalToy);
    }
}

/*
7                        | output : 10 
Aradhel bonecos 10
Aerin arquitetos 15
Anna musicos 10
Elbereth musicos 10
Freda desenhistas 15
Arwen bonecos 10
Logolas bonecos 10
*/