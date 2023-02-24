using System;

class ProgramClass{
    static void Main(){
        uint w = uint.Parse(Console.ReadLine()); // width
        uint l = uint.Parse(Console.ReadLine()); // length

        uint type_one,type_two;

        type_two = (w-1)*2 + (l-1) *2;
        type_one = (w*l) + ((w-1)*(l-1));

        Console.WriteLine(type_one);
        Console.WriteLine(type_two);
    }
}