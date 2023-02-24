using System;

class ProgramClass{
    static string getName(){
        return Console.ReadLine();
    }

    static void print(string n){Console.WriteLine(n);} // print something

    static void Main(){
        string thirdName = "",seventhName = "",ninthName = "";

        for(int i = 1;i <= 10;i++){
            string name = getName();

            if(i == 3)
                thirdName = name;
            else if(i == 7)
                seventhName = name;
            else if (i == 9)
                ninthName = name;
        }

        print(thirdName);
        print(seventhName);
        print(ninthName);    
    }
}