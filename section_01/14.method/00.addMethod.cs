using System;

class Math{
    // defination of add method
    public int cube(int a){
        return a * a * a;
    }
}

class InvokingMethod{
    public static void Main(){
        // create a Math object for invoking add method
        Math mathObject = new Math();
        Console.WriteLine($"mathObject.cube(3) : {mathObject.cube(3)}");
    }
}

/*
methObject.cube(3) : 27
*/