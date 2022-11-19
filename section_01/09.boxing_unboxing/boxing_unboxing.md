Boxing and Unboxing
===================
Boxing means the conversion of a value type on the stack to a object type on the heap. Unboxing is a process converting a object back to the value type. When unbox the object to back must be cast it explicit with real datatype. Syntax of boxing a value type data : 
```cs
object boxName = valueTypeDataName;
```

> 🟢 Boxing is implicit conversion.


Syntax of unboxing a value type data : 
```cs
<dataType> name = <dataType> objectName; // c style cast
```

> 🟢 Unboxing is explicit conversion.

Example of boxing : 
```cs
using System;

class ClassName{
    static void Main(){
        int number = 1000;
        object objectNumber = number; // create objectNumber and assign number

        Console.WriteLine($"number : {number}");
        Console.WriteLine($"objectNumber : {objectNumber}");

        number = 20;
        Console.WriteLine("\n\nAfter changing number 1000 to 20 : ");
        Console.WriteLine($"number : {number}");
        Console.WriteLine($"objectNumber : {objectNumber}");

        objectNumber = 34;
        Console.WriteLine("\n\nafter changing object number to 34");
        Console.WriteLine($"number : {number}");
        Console.WriteLine($"objectNumber : {objectNumber}");

    }
}

/*
output :
number : 1000
objectNumber : 1000


After changing number 1000 to 20 : 
number : 20
objectNumber : 1000


after changing object number to 34
number : 20
objectNumber : 34
*/
```

Example of unboxing : 
```cs
using System;

class ClassName{
    static void Main(){
        int numberInt = 3045;
        object objectNumberInt = numberInt;

        // when unboxing thing cast it c style
        int unboxThingInt = (int) objectNumberInt; // c style cast 

        // below unbox is error, int only unbox as int because int boxing as int
        // float unboxThingFloat = (float) objectNumberInt;
        // double unboxThingDouble = (double) objectNumberInt;

        Console.WriteLine($"unboxThingInt : {unboxThingInt}");
    }
}

/*
output : 
unboxThingInt : 3045
*/
```

<hr />

