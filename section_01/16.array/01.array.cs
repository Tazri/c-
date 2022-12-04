using System;

class ArrayClass{
    static void displayArray(int[] array,int length){
        int i;
        Console.Write($"{array}({length}){{");
        for(i = 0;i < length-1;i++){
            Console.Write($"{array[i]},");
        }

        Console.WriteLine($"{array[i]}}}");
    }

    static void Main(){
        // creating array
        int[] array; // it point nowhere
        array = new int[4]; // allocate memory locations

        // initialization of array
        array[0] = 32;
        array[1] = 123;
        array[2] = 343;
        array[3] = 343;
        Console.WriteLine(array);
        displayArray(array,4);

        // creating and declaring at time
        int[] intArray = new int[2];
        displayArray(intArray,intArray.Length);

        // createing, declaring and initializing at a time
        int []intArrayThree = new int[3]{3,4,5};
        displayArray(intArrayThree,intArrayThree.Length);

        int []intArrayFour = new int[]{19,7,8};
        displayArray(intArrayFour,intArrayFour.Length);

        // more shortcut
        int []intArrayFive = {1,1,1,1};
        displayArray(intArrayFive,intArrayFive.Length);

        
        // below thing is wrong
        /*
        int []arr = new int[3]{34,343,3}; // error
        int []arr = new int[3]{3,3}; // error
        */
    }
}

/*
output : 
System.Int32[]
System.Int32[](4){32,123,343,343}
System.Int32[](2){0,0}
System.Int32[](3){3,4,5}
System.Int32[](3){19,7,8}
System.Int32[](4){1,1,1,1}
*/