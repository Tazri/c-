Type Conversion
================

There are two way to convert data type in C#. Example : 
1. Implicit Convertion.
2. Explicit Convertion.

> 🟢 Implicit type convertion is a automatic type convertion.

Here documented about explicit convertion. In c#, Commonly use three way to do explicit convertion. Here : 
- **[C Style Type Casting](#c-style-type-casting)**
- **[Conveert Class](#convert-class)**
- **[Parse](#parse)**

> 🟢 In explicit type convertion, extra syntax required.

## C Style Type Casting
Here the syntax of C sytle type casting.
```cs
<datatype> variable_name = (<datatype>) value;
```

Example of C style type casting : 
```cs
using System;

class CStyle{
    static void Main(){
        int num = 65;
        
        // c style type convertion
        uint uNum = (uint) num;
        char chNum = (char) num;
        decimal decimalNum = (decimal) num;
        double doubleNum = (double) num;
        float floatNum = (float) num;
        

        Console.WriteLine($"uNum : {uNum}");
        Console.WriteLine($"chNum : {chNum}");
        Console.WriteLine($"decimalNum : {decimalNum}");
        Console.WriteLine($"doubleNum : {doubleNum}");
        Console.WriteLine($"floatNum : {floatNum}");
    }
}

/*
output :
uNum : 65
chNum : A
decimalNum : 65
doubleNum : 65
floatNum : 65
*/
```
## Convert Class
**Convert** class is **System** namespace class which is use for convert specify data type form another datatype. Here table of Convert static method which is use for converting : 

| static Method Name  | convert to                                                           |
|---------------------|----------------------------------------------------------------------|
| ToChar()            | char |
| ToByte()            | bye  |
| ToInt16()           | short|
| ToInt32()           | int |
| ToInt64()           | long|
| ToSByte()           | sbyte|
| ToUInt16()          | ushort|
| ToUInt32()          | uint |
| ToUInt64()          | ulong|
| ToBase64CharArray() | 	Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base-64 digits. |
| FromBase64CharArray(Char[], Int32, Int32) | Converts a subset of a Unicode character array, which encodes binary data as base-64 digits, to an equivalent 8-bit unsigned integer array. Parameters specify the subset in the input array and the number of elements to convert. |

Here the example of type casting using Convert class : 
```cs
using System;

class ConvertClass{
    static void Main(){
        int num = 65;
        string stringFloat = "34.43";
        string stringInt = "343";

        // using Convert class for convert the thing
        char chNum = Convert.ToChar(num);
        double doubleNum = Convert.ToDouble(stringFloat);
        int intNum = Convert.ToInt32(stringInt);
        double doubleNumint = Convert.ToDouble(stringInt);
        short shortNum = Convert.ToInt16(stringInt);
        uint uintNum = Convert.ToUInt32(stringInt);

        Console.WriteLine($"chNum : {chNum}");
        Console.WriteLine($"doubleNum : {doubleNum}");
        Console.WriteLine($"intNum : {intNum}");
        Console.WriteLine($"doubleNumint : {doubleNumint}");
        Console.WriteLine($"shortNum : {shortNum}");
        Console.WriteLine($"uintNum : {uintNum}");
        Console.WriteLine($"Convert.ToInt32(\"-43\") : {Convert.ToInt32("-43")}");
    }
}

/*
chNum : A
doubleNum : 34.43
intNum : 343
doubleNumint : 343
shortNum : 343
uintNum : 343
Convert.ToInt32("-43") : -43
*/
```

## Parse
There are two method **Parse** and **TryParse** using for convert string to double, int, long etc. This method are from float,double, int, long etc. Here syntax : 
```cs
// example of parse
int num = int.Parse(stringValue);

// example of TryParse
bool parseIsSuccess = int.TryParse(stringValue,out outputVariable);
```

> 🟢 The different between **Parse** an **TryPrase** is that **Parse** can throw error but **TryParse** can not throw error.

Example of Parse : 
```cs
using System;

class ClassParse{
    static void Main(){
        int num = int.Parse("345");
        // int num = int.Parse("345.33"); // throw error

        Console.WriteLine($"num : {num}");
    }
}

/*
output : 
num : 345
*/
```

Example of TryParse : 
```cs
using System;

class ClassParse{
    static void Main(){
        int num;

        if (int.TryParse("44",out num)){
            Console.WriteLine($"num : {num}");
        }

        if (int.TryParse("34.33",out num)){
            Console.WriteLine($"num : {num}");
        }
    }
}

/*
output : 
num : 44
*/
```

<hr />
<br />

[< Operator](./../10.operator/operaotr.md) | [Procedural](./../section_01.md) | [Condition >](./../12.condition/condition.md)
------------------------