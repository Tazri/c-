Basic I/O Operation
====================
Here discuss about : 
- **[Allias](#allias)**
- **[Output Method](#output-method)**
- **[Input Method](#input-method)**
- **[Output String Template](#output-string-template)**
- **[Dollar String Template](#)**
- **[Multiple Main Method](#multiple-main-method)**


## Alias
It possible to give a different name class or namespace for use. Here syntax : 

```cs 
using classOrNamespaceName = alias Name;
```

Here example : 
```cs
using S = System;
using P = System.Console;
class ClassName{
    static void Main(){
        S.Console.WriteLine("Hello, S");

        P.WriteLine("Hello, P");
    }
}
```

## Output Method
Commonly use 2 static method of **Console** class for output in c sharp. Here is : 

| Method Name | Description                                                                                           |
| ----------- | -----------                                                                                           |
| Write       | print String, can not create new line                                                                 |
| WriteLine   | print String, create newline                                                                          |

### Write 
Here write example : 
```cs
using System;

class ClassName{
    static void Main(){
        Console.Write("Hello from");
        Console.Write(" same line");
    }
}
```

output : 
```
Hello from same line
```

### WriteLine 
Here writeLine exapmle : 
```cs
using System;

class ClassName{
    static void Main(){
        Console.WriteLine("Hello from");
        Console.WriteLine("Other Line");
    }
}
```

output : 
```
Hello from
Other Line
```
## Input Method 
Commonly use three static method in C sharp for input data from user which is from **Console** class. Here : 

| Method Name | Description                                                                                     |
|-------------|-------------------------------------------------------------------------------------------------|
| Read        | Get a single character return a ascii value                                                     |
| ReadLine    | Get a single line string until newline and return string                                        |
| ReadKey     | Get a character and return ConSoleKey                                                           |

Example Here : 

### Read 
```cs
using System;

class ClassName{
    static void Main(){
        int num;

        Console.Write("Enter anything : ");
        num = Console.Read();

        Console.Write("\nYour thing ASCII code is : {0}",num);
        Console.WriteLine("");
    }
}

/*
output : 
Enter anything : a
Your thing ASCII code is : 97
*/
```

## ReadLine
```cs
using System;

class ClassName{
    static void Main(){
        string any = Console.ReadLine();
        Console.Write("Your String is : ");
        Console.WriteLine(any);
    }
}

/*
output : 
hello
Your String is : hello
*/
```

### ReadKey
```cs
using System;

class ClassName{
    static void Main(){
        ConsoleKeyInfo n = Console.ReadKey();

        Console.WriteLine("\nOutput : ");
        Console.WriteLine(n);
    }
}

// output 
/*
s
Output : 
System.ConsoleKeyInfo
*/
```
## Output String Format
Using string comma format inside the **WriteLine** method syntax : 

```cs
Console.WriteLine("{0},{1},{2}...{n}",variable_one,variable_two,...,variable_n);
```

Example : 
```cs
using System;

class ClassName{
    static void Main(){
        string firstName = "Mr.";
        string lastName = "Alayth";
        Console.WriteLine("{0} {1}",firstName,lastName);
    }
}


/*
output : 
Mr. Alayth
*/
```
## Dollar String Format
This format use for present variable in string Here syntax : 

```
$"{variable_name} {variable_name}";
```

Here example : 
```cs
using System;

class ClassName{
    static void Main(){
        string firstName = "Mr.";
        string lastName = "Alayth";
        string fullName = $"{firstName} {lastName}!";

        Console.WriteLine($"Hello, {firstName} {lastName}");
        Console.WriteLine(fullName);
    }
}

/*
output : 
Hello, Mr. Alayth
Mr. Alayth!
*/
```

## Multiple Main Method
It possible two **Main** method in one program but in that case must be indicate the compiler which entry point he run.Here syntax : 

```bash
$ # csc and mcs is compiler. Use one of them 
$ csc/mcs  -out:output_file_destination input_file_destination /main:className
$ # here compile start from className
```

<hr />
<br />

[< Hello World](./../04/../04.hello_world/04.hello_world.md) | [Procedural](./../section_01.md) | [Literals >](./../06.literals/literals.md)
--------------------------------