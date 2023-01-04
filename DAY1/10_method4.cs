using System;

// C# 4.0 부터 디폴트 파라미터 가능. 선택적 파라미터(Optional Parameter)라고 부름.
class Program
{
    // C++, C#, Python : 지원
    // java, swift : 지원 안함
    public static void goo(int x = 0, int y = 0, int z = 0) { }

    public static void Main()
    {
        goo(1, 2, 3);
        goo(1, 2);      // goo(1, 2, 0) 의 의미
        goo(1);

        // 아래 함수 호출을 보고 인자의 의미를 생각해 봅시다.
        // SetRect(10, 10, 30, 30); // x, y, w, h 일수도 있지만
        //                              x1, y1, x2, y2 일수도 있습니다.

        // 함수 호출을 아래처럼 할수 있으면 어떨까요 ?
        // SetRect(10, 10, width: 30, height: 30);
                // objective-c 언어의 개념
                // swift 와 C# 도 지원 됩니다.


        // C# 에서도 파라미터 전달시 이름 사용가능 합니다.
        // 이름이 있으면 순서 변경 가능합니다.
        goo(x: 1, y: 2, z: 3);
        goo(1, z: 3, y: 2);
        goo(y: 2);


        //
        Base b = new Derived();

        b.foo();

    }

}


class Base
{
    public virtual void foo(int n = 10) { Console.WriteLine($"Base : {n}"); }
}
class Derived : Base
{
    public override void foo(int n = 20) { Console.WriteLine($"Derived : {n}"); }
}
