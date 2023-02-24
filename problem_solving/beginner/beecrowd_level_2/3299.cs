using System;

class SmallUnluckyNumber{
    static bool is_lucky(string numbers){
        for(int i = 0; i < numbers.Length; i++){
            if(numbers[i] == '1'){
                if(i != (numbers.Length -1) && numbers[i+1] == '3'){
                    return false;
                }
            }
        }

        return true;
    }

    static void Main(){
        string numbers = Console.ReadLine();

        if(is_lucky(numbers)){
            Console.WriteLine($"{numbers} NO es de Mala Suerte");
        }
        else{
            Console.WriteLine($"{numbers} es de Mala Suerte");
        }
    }
}