using System;

// 함수 재정의(override)
class Base
{
    // non-virtual : static binding 입니다. 
    //               컴파일시 함수 호출 결정!!
    //    public void Foo() { Console.WriteLine("Base Foo"); }   // 1

    // virtual function : 함수 호출시 dynamic binding을 해달라는 지시어
    public virtual void Foo() { Console.WriteLine("Base Foo"); }   // 1
}
class Derived : Base
{
    // Foo 가 가상함수 일때

    // 1. new를 사용해서 override 하면
    // => 기반 클래스 함수를 override 한것이 아닙니다.
    // => 새로운 Foo 를 만든 것.
    // => C++에는 없는 C# 만의 문법
    // public new void Foo() { Console.WriteLine("Derived Foo"); } // 2


    // 2. 가상함수를 "재정의" 하려면 "override" 키워드 필요
    public override void Foo()
    {
        Console.WriteLine("Derived foo");
    }
}

class Program
{
    public static void Main()
    {
        Base bd = new Derived();

        bd.Foo(); 

    }
}

// java : 모든 메소드가 가상함수 입니다. 그래서 별도의 virtual 키워드가 없습니다.
//       python, swift 도 동일

// C++, C# : virtual 이 붙은 함수만 dynamic binding 합니다.
//           그외에는 컴파일 시간에 호출을 결정합니다.(빠릅니다.)