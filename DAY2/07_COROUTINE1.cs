using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;
// subroutine : 함수가 실행을 완전히 마치고 호출자에게 돌아가는 것.
class Program
{
    public static void Foo()
    {
        int cnt = 0;
        while (++cnt <= 10)
        {
            Console.WriteLine($"Foo : {cnt}");
            Thread.Sleep(1000);
        }
    }
    public static void Main()
    {
        Foo();

        int cnt = 0;

        while (++cnt <= 10)
        {
            Console.WriteLine($"Main : {cnt}");
            Thread.Sleep(1000);
        }
    }
}
