using System;

class Brute{
    static int [] oneTo20 = new int[]{
        4, // 00 zero
        3, // 01 one
        3, // 02 two
        5, // 03 three
        4, // 04 four
        4, // 05 five
        3, // 06 six
        5, // 07 seven
        5, // 08 eight
        4, // 09 nine
        3, // 10 ten
        6, // 11 eleven
        6, // 12 twelve
        8, // 13 thirteen
        8, // 14 fourteen
        7, // 15 fifteen
        7, // 16 sixteen 
        9, // 17 seventeen
        8, // 18 eighteen
        8 // 19 nineteen
    };

    static int [] tenthNumber = new int[]{
        0, // 00 zero
        3, // 10 ten
        6, // 20 twenty
        6, // 30 thirty
        5, // 40  forty
        5, // 50 fifty
        5, // 60 sixty
        7, // 70 seventy
        6, // 80 eighty
        6  // 90 ninety
    };

    static int num(char n){
        return ((int)(n - '0'));
    }

    static void print(int n){
        Console.WriteLine(n);
    }

    static int f(string line){
        int number = int.Parse(line);
        int len = 0;

        if(line.Length == 3){
            return 11;
        }else{
            if(number < 20){
                return oneTo20[number];
            }

            // if number is greater than and it second position is 0
            else if(line[1] == '0'){
                return tenthNumber[num(line[0])];
            }else{
                len = tenthNumber[num(line[0])] + 1; // + 1 for space
                len += oneTo20[num(line[1])];
                return len;
            }
        }

        return len;
    }

    static void Main(){
        // get line
        string line = Console.ReadLine();
        int number = Convert.ToInt32(line);

        for(int i = 1;i <= 1000;i++){
            number = f(Convert.ToString(number));
        }

        Console.WriteLine(number);
        

    }
}