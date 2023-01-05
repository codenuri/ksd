using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;

// subroutine : 함수가 실행을 완전히 마치고 호출자에게 돌아가는 것.
// coroutine  : 함수가 실행중간 에 호출자에게 돌아갈수 있는것.
//              호출자 는다시 중단된 함수를 실행할수 도 있다.

// 언어가 코루틴을 지원하는 것은 꽤 어려운 작업입니다.
// => 지역변수 파괴를 어떻게 관리하는가 가 핵심
// python, swift : 지원
// C++ : C++20 부터지원
// C#  : C# 4.0 부터 지원 - 완벽하지 않다.!! 하지만 linq 의 원리!
//

class Program
{
    // C# 으로 코루틴 만들기
    // 1. 반환 타입은 "IEnumerator" 또는 "IEnumerable" 사용
    // 2. 함수가 중단하고 호출자로 돌아가고 싶을때 yield return 사용

    public static IEnumerable<int> Foo()
    {
        int cnt = 0;
        while (++cnt <= 10)
        {
            Console.WriteLine($"Foo : {cnt}");
            Thread.Sleep(1000);
            yield return cnt; // 1~10 을 순차적으로 반환.
                                // 이 반환 값은 main 에 있는반복자의 Current로 전달
        }
    }
    public static void Main()
    {
        IEnumerable<int> ret = Foo();

        Console.WriteLine("Main 계속 실행");

        // 코루틴이 반환한 컬렉션 인터페이스에서 반복자를 꺼냅니다.
        IEnumerator<int> it = ret.GetEnumerator();

        int cnt = 0;

        while (++cnt <= 10)
        {
            Console.WriteLine($"Main : {cnt}");
            Thread.Sleep(1000);

            it.MoveNext(); // 중단 되었던 코루틴을 재개 합니다.
        }
    }
}
