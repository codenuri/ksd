using System;
using System.Collections.Generic;       

// Enumerator

class Program
{
    public static void Main()
    {
        LinkedList<int> s1 = new LinkedList<int>();

        s1.AddFirst(10);
        s1.AddFirst(20);
        s1.AddFirst(30);

        List<int> s2 = new List<int>();

        s2.Add(10);
        s2.Add(20);
        s2.Add(30);

        // 반복자(iterator) 디자인 패턴 : 컬렉션의 내부 구조에 상관없이
        //                          동일한 방법으로 열거하게 하자.

        // C# 에서는 열거자(enumerator)라고 부릅니다
        // enumerator : 컬렉션 내부의 요소를 가르키는 객체

        var it1 = s1.GetEnumerator();
        var it2 = s2.GetEnumerator();

        /*
        it1.MoveNext(); // 최초에 먼저 한번 호출해야 합니다.
        Console.WriteLine(it1.Current); // 1번째 요소 출력

        it1.MoveNext();
        Console.WriteLine(it1.Current);
        */

        // s1, s2 의 내부 구조는 다르지만 
        // it1, it2의 사용법은 완전히 동일합니다.!
        // => 반복자 패턴의 의미!!. 동일한 방식으로 요소 열거!
        while( it1.MoveNext() )
        {
            Console.WriteLine(it1.Current);
        }

        while (it2.MoveNext())
        {
            Console.WriteLine(it2.Current);
        }
    }
}
