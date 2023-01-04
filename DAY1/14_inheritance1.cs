using System;

// 주제 : 멤버 이름 충돌과 new
class Base
{
    public int value = 10;
}
// 상속의 표기법
// C#     : class Derived : Base
// C++    : class Derived : public Base
// 파이썬  : class Derived(Base)
// java   : class Derived extends Base
// Rust   : 상속 안됨.

class Derived : Base
{
    // 기반 클래스의 멤버와 동일한 이름 사용
    // => 경고는 발생하지만 에러 아니고, 아무 문제 없다.
    // public int value = 20;

    // 경고를 없애려면 new 사용
    public new int value = 20;
}

class Program
{
    public static void Main()
    {
        Derived d = new Derived();
        Console.WriteLine(d.value); // 20
        Console.WriteLine( ((Base)d).value ); // 10
    }
}