using System;

class Base
{
    public Base() { foo(); }

    public virtual void foo() { Console.WriteLine($"Base Foo"); }
}

class Derived : Base
{
    public int x = 200;
    public Derived() : base() { x = 100; }
    public override void foo() { Console.WriteLine($"Derived Foo {x}"); }
}

class Program
{
    public static void Main()
    {
        Base b = new Derived();
    }

}


