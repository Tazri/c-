using System;

namespace NamespaceName{
class ClassOne{
    static void Main(){
        Console.WriteLine("Hello from world One!");
    }
}

class ClassTwo{
   static void Main(){
        Console.WriteLine("Hello from world Two!");
    }
}
}

/*
output One : 
-> mcs -out:./exe/08.multiple_main.exe ./08.multiple_main.cs /main:NamespaceName.ClassOne
-> mono ./exe/08.multiple_main.exe 
Hello from world One!
-> 

-> mcs -out:./exe/08.multiple_main.exe ./08.multiple_main.cs /main:NamespaceName.ClassTwo
-> mono ./exe/08.multiple_main.exe Hello from world Two!
-> 

*/