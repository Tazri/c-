Reference Type and Variable Scope
================================
This chapter noted about reference type of variable and variable scope.

<hr />

## Reference Type
Here user_defined reference type : 
- Classes
- Delegates
- Interface
- Array
  
Here pre-defined referenec type : 
- object
- string

> 🔴 The object type is ultimate base type of all other intrinsic and user-defined types in C#.

Defalut Value of all thing : 

| Type   | Default Value                             |
|--------|-------------------------------------------|
| all integer| 0                                     |
| char   | 'x\000'                                   |
| flaot  | 0.0f                                      |
| double | 0.0d                                      |
| decimal| 0.0m                                      |
| bool   | false                                     |
| enum   | 0                                         |
| all reference | null                               |

## Scope of Variable
C# defines several categories of variable based on scope. Here : 

- Static Variable. (keyword : static)
- Instance Variable.
- Array Elements.
- Value Parameters.
- Reference Parameters. (keyword : ref)
- Output Parameters.
- Local Variable

> 🔴 The scope of variable is region of code within which the variable can be accessed.

Example with below code :
```cs
class ABC{
    static int m;
    int n;
    void fun(int x,ref int y,out int z,int []a){
        int j = 10;
        ...........
        ...........
    }
}
```

here : 
- m as a static variable.
- n as a instance variable.
- x as a value parameter.
- y as a referenec variable.
- z as a output variable.
- a[0] as an array element.
- j as a local variable of **fun** function.

