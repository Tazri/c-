using System;

class HiddenMessage{
    static void Main(){
        int testCase = int.Parse(Console.ReadLine());

        for(int p = 0;p < testCase;p++){
            string line = Console.ReadLine();
            string hiddenMessage = "";
            bool status = false;

            if(line.Length != 0 && (line[0] >= 'a' && line[0] <= 'z')){
                hiddenMessage += line[0];
            }
            

            for(int i = 0;i < line.Length;i++){
                if(line[i] == ' '){
                    status = true;
                }else if(line[i] >= 'a' && line[i] <= 'z'){
                    if(status){
                        status = false;
                        hiddenMessage += line[i];
                    }
                }
            }

            Console.WriteLine(hiddenMessage);
        }
    }
}