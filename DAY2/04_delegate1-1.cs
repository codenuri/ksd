using System;

// delegate 개념
// => 함수(주소)를 보관했다가 필요할때 다시 호출하기 위한 타입.
// 1. 아래 코드 빌드해 놓으세요
// 2. 개발자 명령 프롬프트에서 "ILDASM" 실행하세요.
// 3. ILDASM 에서 실행파일 열어 보세요(bin/debug/Day2.exe)

// delegate 키워드를 사용하면 함수주소를 저장하는 타입을 만들수 있습니다.

// FP : void (int) 모양의 함수(주소)를 저장하는 타입
delegate void FP(int arg);



// 위 한줄을 보고 C# 컴파일러가 아래 클래스를 생성합니다.
// 즉, 위 코드는 클래스를 만들어 달라는 요청입니다.
/*
class FP : MulticastDelegate
{
    // void(int) 모양의 함수 주소를 저장할수 있는 멤버 추가
    // MulticastDelegate 로 부터 invoke 등의 함수를 물려 받음.
}
*/


class Program
{
    public static void Foo(int a) 
    {
        Console.WriteLine($"Foo : {a}");
    }
    public static void Main()
    {
        // 1. Delegate 를 사용하는 정확한 코드
        FP f1 = new FP(Foo);

        // 2. 아래처럼 할수도 있습니다. 
        FP f2 = Foo; // 컴파일러가 결국
                     // FP f2 = new FP(Foo) 로 변경합니다.

        // 3. delegate 를 사용해서 함수 호출
        f1.Invoke(10);  // Foo(10) 의 의미
        f1(10);         // 위 코드와 동일
    }
}
