using System;

// 상속과 생성자
// => 다른 객체지향 언어에서도 꼭 확인해 보세요(java, python 등)

// 객체 생성시
// => 기반 클래스 생성자도 호출된다.
// => 순서는 ?

// 핵심 : 상속 관계에서 생성자 호출의 원리를 정확히 이해해 두세요

class Base
{
//    public Base()      { Console.WriteLine("Base()"); }
    public Base(int a) { Console.WriteLine("Base(int)"); }
}

class Derived : Base
{
    /*
    // 사용자가 만든 코드       // 컴파일러가 변경한 코드
    public Derived()           // Derived() : base()  
    { 
        Console.WriteLine("Derived()");
    }
    public Derived(int a)       // Derived(int a) : base()  // 컴파일러가 
    {                                           // 추가한 코드는 항상
                                                // 기반 클래스 디폴트 생성자호출
        Console.WriteLine("Derived(int)"); 
    }
    */

    // 기반 클래스에 디폴트 생성자가 없거나...
    // 기반 클래스의 다른 생성자를 호출하려면 반드시 사용자가 명시적으로
    // 호출해야 합니다.
    public Derived()      : base(0) {}
    public Derived(int a) : base(a) {}
}

class Program
{
    public static void Main()
    {
        // Derived d = new Derived();
        Derived d = new Derived(5);

        // 다음중 에러를 찾으세요
        Animal a = new Animal();    // 생성자가 protected 이므로!
        Dog d = new Dog();          // 
    }
}
// protected 생성자를 사용하는의도!
// => 자신은 객체를 만들수 없지만(추상적 존재)!!!
// => 파생 클래스는 객체를 만들수 있게(구체적 존재) 하기 위한 의도!!
// => 라이브러리 설계에서 자주 사용되는 디자인 기법. 

class Animal
{
    protected Animal() { }
}
class Dog : Animal 
{
}


