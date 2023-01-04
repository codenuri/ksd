using System;

// 함수 재정의(override)
class Base
{
    public void Foo() { Console.WriteLine("Base Foo"); }   // 1
}
class Derived : Base
{
    // 아래코드는 경고 입니다.
    //    public void Foo() { Console.WriteLine("Derived Foo"); } // 2

    public new void Foo() { Console.WriteLine("Derived Foo"); } // 2
} 

class Program
{
    public static void Main()
    {
        Base    b = new Base();
        Derived d = new Derived();

        b.Foo();    // 1. Base Foo
        d.Foo();    // 2. Derived Foo

        // 핵심 : 아래 코드의 결과를 생각해 봅시다.
        Base bd = new Derived();

//      if (사용자 입력 == 1) bd = new Base();

        // 컴파일 시간에 컴파일러는 bd가 어떤 객체를 가리키는지 알수 있을까요 ?

        bd.Foo();   // "Derived Foo" 가 논리적으로는 맞는 동작 입니다.
                    // java, swift, python : Derived Foo
                    // C++, C#  : Base Foo

    }
}

// bd.Foo() 를 실제 어느 함수로 연결할것인가 ? => 함수 바인딩 이라고 합니다.

// 1. static binding : 컴파일러가 컴파일 시간에 함수 호출을 결정하는 것
//                     컴파일러는 bd 가 가리키는 실제 객체가 어떤 타입인지는
//                     알수없습니다.!!!
//                     유일하게 알수 있는 것은 "bd" 자체가 Base 타입이라는것!!
//                     따라서, "Base Foo" 호출.
// 비 논리적인 동작, 빠르다
// C++/C# 의 기본 바인딩 정책

// 2. dynamic binding : 컴파일시간에 bd가 가리키는 메모리를 조사하는 기계어 코드생성
//                  실행시 메모리를 조사후에 객체가 어떤 종류인지에 따라 호출
//                  "Derived" 타입의 객체가 있었다면
//                  "Derived Foo" 호출
// 논리적인 동작, 느리다.
// C++/C# 가상함수의 기본 바인딩 정책
// java, swift, python 등 대부분의 객체지향 언어의 방식