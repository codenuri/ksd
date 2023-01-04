using System;

// 주제 : 생성자와 가상함수 호출

class DM
{
    public DM()         { Console.WriteLine("DM()"); }
    public void UseDM() { Console.WriteLine("Use DM"); }
}

class Base
{
    // 생성자와 가상함수 호출
    public Base() { foo(); }
    public virtual void foo() { Console.WriteLine("Base foo()"); }
}

class Derived : Base
{
    public DM dm = new DM();

    public Derived() { }

    public override void foo()
    {
        Console.WriteLine("Derived foo()");
        dm.UseDM();
    }
}


class Program
{
    public static void Main()
    {
        Derived d = new Derived();
    }
}