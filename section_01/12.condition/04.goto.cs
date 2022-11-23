using System;

class GotoClass{
    static void Main(){
        Console.WriteLine("Hello, World!");

        goto EndLebel;

        Console.WriteLine("Do you know me ?");

        EndLebel :
        Console.WriteLine("!!Here I am!!");

    }

}

/*
output :
Hello, World!
!!Here I am!!
*/