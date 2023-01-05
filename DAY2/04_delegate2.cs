using System;

// Multicast Delegate
// FP : 클래스로 만들어진 타입, reference type, immutable
// FP 에 저장하는 함수 모양 : 반환 타입 void, 인자는 int 한개
delegate void FP(int a);

class Program
{
    public static void Foo(int a) { Console.WriteLine($"Foo : {a}"); }
    public static void Goo(int a) { Console.WriteLine($"Goo : {a}"); }
    public void Hoo(int a)        { Console.WriteLine($"Hoo : {a}"); }

    public static void Main()
    {
        // 핵심 1. delegate 에 함수 등록하기
        FP f1 = new FP(Foo); // 정확한 모양
        FP f2 = Foo;         // 일반적으로 사용하는 방식

        // 2. static method는 객체 없이 호출가능하므로 그냥 아래 처럼 등록 가능.
        FP f3 = Foo;         // static 메소드 등록 방법 1.
        FP f4 = Program.Foo; // static 메소드 등록 방법 2. 

        // 3. instance method 는 객체 생성후, 객체와 같이 등록
        Program p = new Program();
        FP f5 = p.Hoo;

        // 4. 하나의 델리게이트에 여러개 함수 등록 가능, +=, -= 사용
        FP f = Foo;
        f += Goo;
        f += p.Hoo;

        f(10); // 등록된 모든 메소드 호출.


    }
}