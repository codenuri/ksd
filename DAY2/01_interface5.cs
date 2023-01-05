using System;

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = 20;

        string s1 = "AAA";
        string s2 = "BBB";

        // 2개 객체의 크기를 비교 하는 방법
        // 1. < 연산자 사용
        bool b1 = n1 < n2;
//      bool b2 = s1 < s2; // error. 

        // 2. CompareTo 메소드 사용
        int ret1 = n1.CompareTo(n2); // n1 이 크면 양수, 작으면 음수, 같으면 0
        int ret2 = s1.CompareTo(s2); // ok.. 

        Foo(s1); // ok.. string 은 ICloneable 인터페이스 구현
 //     Foo(n1); // error. int 는 ICloneable 인터페이스 구현 안함.

        // ICloneable 인터페이스를 구현한 타입의 객체에만 "Clone()" 메소드가 있다
    }

    // 복제(ICloneable 인터페이스를 구현한) 가능한 모든 타입의 객체를 받을수있다.
    public static void Foo(ICloneable obj)
    {
        object o1 = obj.Clone();
    }
}





