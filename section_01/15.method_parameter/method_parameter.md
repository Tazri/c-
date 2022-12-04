# Method Parameter
---------------------
C# has four kind of parameter. Here : 
1. **[Value Parameter](#value-parameter)**
2. **[Reference Parameter](#reference-parameter)**
3. **[Output Parameter](#output-parameter)**
4. **[In Parameter]()**
5. **[Parameter Arrays](#parameter-arrays)**

<hr />

## Value Parameter
value parameter as known as **pass by value**. In C# by default parameters are passed by value. It can not change real variable. Here example : 

```cs
using System;

class ChangeValue{
    static void changeValue(int y){
        y += 43;
    }

    static void Main(){
        int x = 3;
        changeValue(x);
        Console.WriteLine($"x : {x}");
    }

}
```

## Reference Parameter
Reference parameter as known as pass by **reference**. A parameter declared with the **ref** modifier is a reference parameter. Syntax : 

```cs
void modify(ref int x){...};
```

Example : 

```cs
using System;

class RefClass{
    static void Main(){
        int a = 19, b = 23;

        Console.WriteLine("> Before Swaping <");
        display(a,b);

        swap(ref a,ref b);

        Console.WriteLine("> After Swaping <");
        display(a,b);
    }

    static void display(int a,int b){
        Console.WriteLine($"> a = {a}");
        Console.WriteLine($"> b = {b}");
    }

    static void swap(ref int a,ref int b){
        a = a*b;
        b = a/b;
        a = a/b;
    }
}

/*
> Before Swaping <
> a = 19
> b = 23
> After Swaping <
> a = 23
> b = 19
*/
```

> 🔴 Before passing ref parameter must be change intialize it.

## Output Parameter
This is similler to a reference parameter. But it declearing the parameters with an `out` keyword. An output parameter dose not create a new storage location. Instead, it becomes an alias to the parameter in the calling method.

> 🟢 Dose not necessary to intialize variable before passing it in **out** parameters.

Example : 
```cs
using System;

class OutClass{
    static void Main(){
        int m;
        square(10,out m);

        Console.WriteLine($"m : {m}");
    }

    static void square(int x,out int m){
        m = x*x;
    }
}

/*
m : 100
*/
```

## In Parameter
A parameter which has declared with `in` modifier that called In parameter. This type of parameter contain reference which never be change. Syntax : 
```cs
<return_Type> methodName(in <data_type> parameterName){
    ..........
    ..........
}
```

> 🔴 `in` keyword parameter feture available in c# 7.2 upper version.

Here exapmle :

```cs
using System;

class Student{
    string name = "anonymous";
    int age = 0;

    public void displayStudent(){
        Console.WriteLine($"{name}({age})");
    }

    public void ChangeName(string s){
        name = s;
    }

    public void ChangeAge(int a){
        age = a;
    }
}

class InParameter{
    public static void Main(){
        Student me = new Student();

        modify("Md Tazri",21,in me);
        me.displayStudent();
    }

    // in parameter
    static void modify(string name,int age,in Student s){
        s.ChangeName(name);
        s.ChangeAge(age);

        // below thing must be throw a error
        // s = new Student();

        // because in type parameter can not be changeable reference
    }
}

/*
output : 
Md Tazri(21)
*/
```

## Parameter Arrays
In C#, It possible to define methods that can handle variable number of arguments using what are known as **parameter arrays.** Parameter arrays are declared using the keyword `params`. The syantx : 

```cs
<return_type> methodName(params int[] x){
    ......
    ......
}
```

The method methodName above defined can be invoked in two ways : 
1. Usig **int** type array as a value parameter, example : `methodName(a);` here, a is an array of type int.
2. Using zero or more int type argument for parameter array. Example : `methodName(4,4);`

Example of Parameter array : 
```cs
using System;

class ParameterArray{
    static void displayInt(params int []intArray){
        foreach( int i in intArray){
            Console.WriteLine($"{i}");
        }
    }

    static void Main(){
        int [] intArray = {3,4,5,2,1};

        Console.WriteLine("displayInt(intArray) : ");
        displayInt(intArray);

        Console.WriteLine("displayInt(4,3,2,4) : ");
        displayInt(4,3,2,4);

        Console.WriteLine("displayInt() :");
        displayInt();
    }
}

/*
displayInt(intArray) : 
3
4
5
2
1
displayInt(4,3,2,4) : 
4
3
2
4
displayInt() :
*/
```

Another example with object : 
```cs
using System;

class ObjectParams{
    static void Main(){
        Console.WriteLine("printObject(3,4,'a') : ");
        printObject(3,4,'a');

        Console.WriteLine("printObject(\"hello,\", \"World\") : ");
        printObject("hello","world");

        Console.WriteLine("printObject() : ");
        printObject();
    }

    // below object params
    static void printObject(params object []objectArray){
        foreach(object o in objectArray){
            Console.Write($"{o} ");
        }
        Console.WriteLine();
    }

}

/*
output : 
printObject(3,4,'a') : 
3 4 a 
printObject("hello,", "World") : 
hello world 
printObject() : 
*/
```

<hr />
<br />

[< ]() | [Procedural]() | [ >]()
-----------------