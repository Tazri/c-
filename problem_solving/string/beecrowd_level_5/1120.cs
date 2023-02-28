using System;

class ContractRevision{
    static void Main(){
        string line = Console.ReadLine();

        while(true){
            string []words = line.Split(' ');

            char remove = words[0][0];
            string number = words[1];

            if(remove == '0' && number == "0"){
                break;
            }

            string finalNumber = "";

            for(int i = 0;i < number.Length;i++){
                if(remove != number[i]){
                    if(number[i] == '0'){
                        if(finalNumber != ""){
                            finalNumber += number[i];
                        }
                    }else{
                        finalNumber +=number[i];
                    }
                }
            }

            if(finalNumber == ""){
                Console.WriteLine(0);
            }else{
                Console.WriteLine(finalNumber);
            }
            
            line = Console.ReadLine();
        }
    }
}