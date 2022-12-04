Method
=======
Here noted about : 
- **[Method Declaration](#method-declaration)**
- **[Invoking Method or Calling Method](#invoking-method)**
- **[Static Method](#static-method)**
- **[Nesting Method](#nesting-method)**
- **[Method Overloading](#method-overloading)**

<hr />

## Method Declaration
Methods are declared inside the body of class. Here syntax of method declaration : 

```cs
<modifiers> <return_type> MethodName(parameter_list){
    // method body

    retrun // return something if it void then don't do that
}
```

Five part of method declaration : 
1. Name of the method. (MethodName)
2. Type of value the method return. (<return_type>)
3. List of Parameter. (parameter_list)
4. Body of Method.
5. Method Modifiers. (<modifiers>)
   
The modifiers spacifier keywords that decide the nature of accessibility and the mode of application of the method. A method can take one or more modifier in below list : 

| Modifiers Name  | Description                                                                                         |
|-----------------|-----------------------------------------------------------------------------------------------------|
| new             | The method hides an inherited method with the same signature.                                       |
| public          | The method can be accessed from anywhere, including outside the class                               |
| protected       | The method can be accessed from with in the class to which it belongs or type derived from the class|
| internal        | The method can be accessed from within the same program            |
| private         | The method can only be accessed from inside the class to which it belongs |
| static          | The method dose not operate on a spacifie instance of the class |
| virtual         | The method can be overridden by a derived class. |
| abstract        | A virtual method which defines the signature method, but dosen't provide implementation. |
| override        | The method override an inherited virtual or abstract method. |
| sealed          | The method override an inherited virtual method, but cannot be overridden by any classes which inherit from this class. Must be used in conjunction with override. |
| extern          | The method is implemented externally, in a different language. |

> 🟢 Modifiers Sequence dose not metter! public static or static public same thing in c#.

## Invoking method
The process of activating  a method is known as invoking or calling. Here syntax of invoking method : 

```cs
<className> objectName = new <className>(); // create a object
objectName.mehtodName(actual_parameter_list); // calling or invoking method
```

Example : 
```cs
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
```

## Static Method
A method which is dose not creating object for call or invoking it, that's method called static method. Here the syntax of static methdo : 

```cs
static <access_spacifier> <return_type> MethodName(parameter_list){
    // statement
    return // return something
}
```

Here example : 
```cs
using System;

class DisplayClass{
    // public static method
    public static void display(string n){
        Console.WriteLine(n);
    }
}

class StaticMethod{
    // below a static method
    static void print(string s){
        Console.WriteLine(s);
    }
    static void Main(){
        print("Hello World! From Print");
        
        DisplayClass.display("Hello, Universe! From DisplayClass!!");

    }
}

/*
Hello World! From Print
Hello, Universe! From DisplayClass!!
*/
```

## Nesting Method
Call a method from another method at a same class or another class called **nesting method**. Here example : 

```cs
using System;


class MainClass{
    static void Main(){
        MainClass o = new MainClass();

        Console.WriteLine($"o.large(3,5) : {large(3,5)}");
    }
    
    public  
    int large(int a,int b){
        return max(a,b);
    }

    private int max(int a,int b){
        if(a >b)return a;
        else return b;
    }

}
```

> 🔴 Inside static method, must create object for called a class method which is not static.


## Method Overloading
C# allows us to create more than one method with the same name, but with the different parameter lists and different defination. This is called **method overloading**.

> 🟢 In method overloading, it's important to different parameter each method but return type is not metter.

Here example : 
```cs
// method defination
int add(int a,int b,int c){...} // method 1
float add(float a,float b, float c){...} // method 2

// method calls
int m1 = add(5,10); // call method 1
float m2 = add(4.3f,43.3f,3.3f); // call method 2
```

The method selection involves the following steps : 
1. The compiler tries to find the exact match in which the types of actual parameter are the same and uses that method.
2. If the exact match not found, the compiler tries to implicit conversions to the actual arguments and uses the method whose match is unique. If the conversion creates multiple matches, then compiler will generate an error message.

Example of Method Overloading : 
```cs
using System;

class MethodOverloading{
    static int volume(int baseSize){ // for cube
        return baseSize*baseSize*baseSize;
    }

    static double volume(double height,double baseSize){// for triangle
        return 0.5*height*baseSize;
    }

    static void Main(){
        Console.WriteLine($"volume(10) : {volume(10)}");
        Console.WriteLine($"volume(10,20) : {volume(10,20)}");

    }
}

/*
output : 
volume(10) : 10000
volume(10,20) : 100
*/
```

<hr />
<br />

[< ]() | [Procedural](./../section_01.md) | [ >]()
------------------------------