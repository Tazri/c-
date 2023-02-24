using System;

class ProgramClass{
    static string printChar(int n,char c = ' '){
        string s= "";

        for(int i = 0;i < n;i++){
            s+= c;
        }

        return s;
    }

    static string justifiedCharStart(string n,int length,char c = ' '){
        if(n.Length >= length){
            return n;
        }

        string result = "";

        // check it minus or not
        int printFrom = n[0] == '-' && c == '0' ? 1 : 0;

        if(printFrom == 1){
            result += "-";
        }

        // char add
        for(int i =0; i < (length-n.Length);i++){
            result += c;
        }

        // string add
        for(;printFrom<n.Length;printFrom++){
            result += n[printFrom];
        }

        return result;
    }

    static string justifiedspaceEnd(string n,int length){
        if(n.Length >= length){
            return n;
        }
        string finalString = n;
        // total space to be print
        int totalSpace = length - n.Length;

        for(int i =0;i < totalSpace;i++){
            finalString += " ";
        }

        return finalString;
    }

    static void printNumber(string a,string b,string c){
        Console.WriteLine($"A = {a}, B = {b}, C = {c}");
    }
    static void Main(){
        // get numbers 
        string a = Convert.ToString(int.Parse(Console.ReadLine()));
        string b = Convert.ToString(int.Parse(Console.ReadLine()));
        string c = Convert.ToString(int.Parse(Console.ReadLine()));

        // print a b c
        printNumber(a,b,c);

        // justified them with space at start
        string spaceA10 = justifiedCharStart(a,10);
        string spaceB10 = justifiedCharStart(b,10);
        string spaceC10 = justifiedCharStart(c,10);
        printNumber(spaceA10,spaceB10,spaceC10);

        // justified them with zero at start
        string zeroA10 = justifiedCharStart(a,10,'0');
        string zeroB10 = justifiedCharStart(b,10,'0');
        string zeroC10 = justifiedCharStart(c,10,'0');
        printNumber(zeroA10,zeroB10,zeroC10);

        // justified them with space at end
        string a10Space = justifiedspaceEnd(a,10);
        string b10Space = justifiedspaceEnd(b,10);
        string c10Space = justifiedspaceEnd(c,10);
        printNumber(a10Space,b10Space,c10Space);
    }
}

