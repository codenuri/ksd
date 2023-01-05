using System;

class Program
{
    // generic method 
    public static void Foo<T>(T n)    { }

    public static void Main()
    {
        Foo<int>(10); // 방법 1. 사용자가 타입을 명시적으로 전달하는 방법.

        Foo(10);  // 2. 타입을 전달하지 않으면 컴파일러가 인자를 보고 추론
                    // Foo(int) 버전 함수 생성

        Foo("AA"); // T=string 으로 추론
                    // Foo(string) 버전 함수 생성
    }
}
