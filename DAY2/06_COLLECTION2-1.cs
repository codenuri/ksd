using System;
using System.Collections.Generic;


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

        // 핵심 1. 모든 컬렉션에는 열거자를 꺼내는 "GetEnumerator()" 메소드가 있어야한다.
        // => 모든 컬렉션은 "IEnumerable<T>" 인터페이스를 구현해야 한다.
        // var it1 = s1.GetEnumerator();
        // var it2 = s2.GetEnumerator();


        // 핵심 2. 모든 종류의 열거자(반복자)는 사용법이 동일해야한다.
        // => MoveNext()로 이동하고, Current 로 요소 접근
        // => 모든 열거자는 "IEnumerator<T>" 인터페이스를 구현해야 한다.
        IEnumerator<int> it1 = s1.GetEnumerator(); // new linked_list_enumerator()
        IEnumerator<int> it2 = s2.GetEnumerator(); // new list_enumerator()



        while (it1.MoveNext())
        {
            Console.WriteLine(it1.Current);
        }

        while (it2.MoveNext())
        {
            Console.WriteLine(it2.Current);
        }
    }
}
