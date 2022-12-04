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