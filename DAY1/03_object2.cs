using System;

// 모든 타입은 object로 부터 파생 된다.
// int의 원리
/*
struct int : object 
{
    //......
    // object 로 부터 4개의 인스턴스 메소드
    //               2개의 static method 를 상속 받고..

    // int 자신에 추가한 멤버들..
}
*/

class Program
{
    // object 를 인자로 받는 메소드는 모든 객체를 받을수 있습니다.
    public static void Foo(object o)
    {
        // 모든 타입에는 ToString 은 있습니다.
        string s = o.ToString();
        Console.WriteLine(s);
    }
    public static void Main()
    {
        Foo(10);
        Foo(3.4);
        Foo("hello");

        // Console.WriteLine 은 모든 객체를 받을수 있습니다.
        // => 인자가 object 인 버전이 있습니다.
        Console.WriteLine(10);
        Console.WriteLine(3.4);
    }
}