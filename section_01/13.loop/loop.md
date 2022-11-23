Loop
====
In c# program support 4 type of loop : 
- **[while loop](#while-loop)**
- **[do while loop](#do-while-loop)**
- **[for loop](#for-loop)**
- **[goto](#goto)**
- **[foreach](#foreach)**
- **[break and continue](#break-and-continue)**

## while loop
syntax of while loop in c# : 
```cs
while(boolean_expression){
    // statement
}
```

example : 
```cs
using System;

class WhileLoop{
    static void Main(){
        int i = 0;

        while(i < 5){
            Console.WriteLine($"Hi Mr.{i++}");
        }
    }
}

/*
output : 
Hi Mr.0
Hi Mr.1
Hi Mr.2
Hi Mr.3
Hi Mr.4
*/
```

## do while loop
do while syntax : 
```cs
do{
    // statemen
}while(boolean_expression);
```

Do while example : 
```cs
using System;

class DoWhile{
    static void Main(){

        do{
            Console.WriteLine("Hello Universe");
        }while(false);
    }
}

/*
output : 
Hello Universe
*/
```

## for loop
for loop syntax : 
```cs
for(initialization;boolean_condition;increment_dcrement){
    // statement
}
```

Example : 
```cs
using System;

class ForLoop{
    static void Main(){
    

        int i = 0;

        for(i = 0;i <= 5; i++){
            Console.WriteLine($"Hello Mr.{i}");
        }
        
        Console.WriteLine("loop end");        


    }
}
```
## foreach
**foreach** another loop in c# which is commonly use for traverse array or collection type string. Here syntax of foreach : 

```cs
foreach (<datatype> variable_name in array_or_collection_class){
    // statment
}
```

example of foreach :
```cs
using System;

class ForeachLoop{
    static void Main(){
        string word = "hell";

        foreach(char ch in word){
            Console.WriteLine($"ch {ch}");
        }
    }
}

/*
output : 
ch h
ch e
ch l
ch l
*/
```


## break and continue
**break** keyword use for stop the loop immediately. **continue** keyword skip the current loop iteration and go next iteration.

Example of continue: 
```cs
using System;

class ClassContinue{
    static void Main(){
        int i = 0;

        for(; i < 10;i++){
            if((i & 1) == 1) continue; // skip if it odd
            Console.WriteLine($"Hello, Mr. {i}");
        }
    }
}

/*
output : 
Hello, Mr. 0
Hello, Mr. 2
Hello, Mr. 4
Hello, Mr. 6
Hello, Mr. 8
*/
```

Example of break: 
```cs
using System;

class BreakClass{
    static void Main(){
        int i = 0;

        while(i++ < 10){
            if(i == 4) break;
            Console.WriteLine($"Hello, Mr. {i}");
        }
    }
}

/*
output : 
Hello, Mr. 1
Hello, Mr. 2
Hello, Mr. 3
*/
```

## goto 
It documented previous documentation. Go to [Condition chapter for this](./../12.condition/condition.md).

<hr />
<br />

[< Condition](./../12.condition/condition.md) | [Procedural >](./../section_01.md)
---------