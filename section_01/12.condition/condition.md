Flow Control
============
Here Flow Control syntax in C# :
1. **[if else condition](#if-else-condition)**
2. **[without range if else condition](#without-range-if-else)**
3. **[switch](#switch)**
4. **[goto](#goto)**


## if else condition
if syntax : 
```cs
if (<boolean_expression>){
    // statement
}
```

else if syntax : 
```cs
if (<boolean_expression>){
    // statement
}else if(<boolean_expression>){
    // statement
}
```

full else if syntax : 
```cs
if (<boolean_expression>){
    // statement
}else if(<boolean_expression>){
    // statement
}else{
    // statement
}
```

Example of using if else condition:
```cs
using System;

class IfElseClass{
    static void Main(){
        int num;

        Console.Write("Enter num : ");
        string input = Console.ReadLine();

        if(int.TryParse(input,out num)){
            if(num % 2 == 0){
                Console.WriteLine($"{num} is EVEN.");
            }else{
                Console.WriteLine($"{num} is ODD.");
            }
        }else{
            Console.WriteLine("> Please Enter Correctly <");
        }
    }
}

/*
Enter num : 454
454 is EVEN.
*/
```

## without range if else
It possible to use if else without range by single bracket. Here syntax : 
```cs
if(boolean_expression)
    // statement
else if(bookean_expression)
    // statement
else 
    // statement
```

> 🔴 In that case, if else condition count only one statement.


Example of if else using endention.
```cs
using System;

class IfElseClass{
    static void Main(){
        int num;

        Console.Write("Enter num : ");
        string input = Console.ReadLine();

        // indention if else
        if(int.TryParse(input,out num))
            if(num % 2 == 0)
                Console.WriteLine($"{num} is EVEN.");
            else
                Console.WriteLine($"{num} is ODD.");
            
        else
            Console.WriteLine("> Please Enter Correctly <");
        
    }
}

/*
Enter num : 454
454 is EVEN.
*/
```

## switch
switch syntax in c# : 
```cs
switch(expression){
    case value_1 :
        // statement
        break;
    case value_2 :
        // statement
        break;
    case value_3 : 
        // statement
        break;
    .................
    .................
    .................
    case value_n : 
        // statement
        break;
}
```

Example of switch : 
```cs
using System;

class TextNumber{
    static void Main(){
        Console.Write("Enter num 1 to 3 :");

        int num = int.Parse(Console.ReadLine());

        // print text
        switch(num){
            case 0 : 
                Console.WriteLine("Zero");
                break;
            case 1 : 
                Console.WriteLine("One");
                break;
            case 2 : 
                Console.WriteLine("Three");
                break;
            default :
                Console.WriteLine("I don't know Number :(");
                break;
        }
    }
}

/*
output : 
Enter num 1 to 3 :2
Three
*/
```

## goto 
**goto** keyword use in c# for jump to the code to lebel. Where example : 

```cs
goto lebelName;

lebelName : 
```

> 🟢 it possible to use goto in switch for goto another case example : `case value;`

```cs
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
```

<hr />
<br />

[< Type Convertion](./../11.type_conversion/type_conversion.md) | [Procedural](./../section_01.md) | [Loop >](./../13.loop/loop.md)
---------