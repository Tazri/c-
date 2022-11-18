Literals
=========
C sharp supports 3 kind of literal. Here all thing : 

1. Numberic Literal. (Integer, Real).
2. Boolean. 
3. Character. (single character and Strings).

## Integer Literal 
There are two type of integer. Here
- Decimal
- Hexadecimal

Decimal and hexadecimal literal example : 
```cs
// decimal 
34343;
343;

// hexa decimal 
0xAA;
0xFF;
```

## Real Literal
Here the example of Real Literal : 
```cs
343.34343; // double
3.43E3; // double (mantissa)
```

example : 
```cs
using System;

class ClassName{
    static void Main(){
        double doubleNumber = 3.454;
        double mantissaNumber = 3.3E2; // 
        double anotherDoubleNumber = 4.454e3;

        Console.WriteLine($"doubleNumber : {doubleNumber}");
        Console.WriteLine($"mantissaNumber : {mantissaNumber}");
        Console.WriteLine($"anotherDoubleNumber : {anotherDoubleNumber}");
    }
}

/*
output : 
doubleNumber : 3.454
mantissaNumber : 330
anotherDoubleNumber : 4454
*/
```

## Boolean Literal
Here two boolean literal : 
```cs
true;
false;
```

## Single Character Literal
Character type value define must with single character '. Here the syntax : 
```cs
'd';
'd';

"d"; // this is wrong
```

## String Literal 
String define with double qoutatoin. Here example : 
```cs
"This is string";
```
