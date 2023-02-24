using System;

class ExcelBug{
    static long getCharCode(char c){
        return c - 'A' + 1;
    }

    static long getColumnCode(string col){
        long code = 0;
        long i = 0;

        for(int index = col.Length-1;index >= 0;i++,index--){
            code += getCharCode(col[index]) * Convert.ToInt64(Math.Pow(26,i));
            
        }

        return code;
    }

    static void Main(){
        long upperBound = getColumnCode("XFD");

        // get input 
        string line = Console.ReadLine();

        while(line != null){
            long code = getColumnCode(line);



            if(line.Length <= 3 && code <= upperBound){
                Console.WriteLine(code);
            }else{
                Console.WriteLine("Essa coluna nao existe Tobias!");
            }

            line = Console.ReadLine();
        }
    }
}