// method4 복사해오세요
using System;

class Base
{
    // dynamic binding
    public virtual void foo(int n = 10) { Console.WriteLine($"Base : {n}"); }
}
class Derived : Base
{
    public override void foo(int n = 20) { Console.WriteLine($"Derived : {n}"); }
}

class Program
{
    public static void Main()
    {
        Base b = new Derived();

        // 아래 코드 실행결과 예측해 보세요.
        b.foo(); // Derived : 10
                 // 원래 foo 는 인자가 있는데, 전달하지 않으므로
                 // 디폴트 값을 사용해야 합니다.
                 // => 디폴트 값은
                 //   "컴파일시에 컴파일러가 함수 호출코드에 채우게 됩니다."
                 // b.foo(10) 으로 변경(Base 타입의 디폴트 값)
                 // 그런데, 어느 foo를 호출하는 지는 실행시간에 결정

        // 컴파일 시간에 동작하는 문법과
        // 실행시간에 동작하는 문법을 잘 알아 두세요

        // 2개 문법을 섞어서 사용할때 "아주 주의 하세요"

        // 가상 함수에서는 디폴트 인자를 되도록 사용하지 마세요
        // 사용했다면 가상 함수 override 시에 디폴트 값 변경하지 마세요

    }

}


