using System;

class Program
{
    public static void Foo(int a) { }

    public static void Main()
    {
        int    n = 10;  // int    : 정수를 저장하는 데이타 타입
        double d = 3.4; // double : 실수를 저장하는 데이타 타입

        ? f = Foo; // ? : 함수(정확히는 함수주소)를 저장하는 데이타 타입이 필요하다.
                    // => "delegate" 문법으로 만들어야 한다.
                    // => C/C++ 언어의 함수 포인터 타입!
    }
}