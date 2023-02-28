using System;

class AlarmClock{
    static void Main(){
        string line = Console.ReadLine();

        while(true){
            string []words = line.Split(' ');
            int h1 = int.Parse(words[0]);
            int m1 = int.Parse(words[1]);
            int h2 = int.Parse(words[2]);
            int m2 = int.Parse(words[3]);
            int totalMinute = 0;
            int totalHour = 0;

            // break point
            if(h1 == 0 && h2 == 0 && m1 == 0 && m2 == 0){
                break;
            }

            if(h1 < h2){
                totalHour = h2 - h1 - 1;
                totalMinute = (60 - m1) + m2;
            }else if(h2 < h1){
                totalHour = (23 - h1) + h2;
                totalMinute = (60 - m1) + m2;
            }else{ // if h1 == h2
                if(m1 < m2){
                    totalHour = 0;
                    totalMinute = m2 - m1;
                }else if(m1 > m2){
                    totalHour = 23;
                    totalMinute = (60 - m1) + m2;
                }else{ // m1 == m2
                    totalHour = 0;
                    totalMinute = 0;
                }
            }

            totalMinute += totalHour * 60;

            Console.WriteLine(totalMinute);

            line = Console.ReadLine();
        }
    }
}