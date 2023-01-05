using System;
using System.Collections;               // 1. non generic collections
using System.Collections.Specialized;   // 2. 타입에 특화된 collections
using System.Collections.Generic;       // 3. generic collections
using System.Collections.ObjectModel;   // 4. for Custom collections 
using System.Collections.Concurrent;    // 5. thread safe collections

class Program
{
    public static void Main()
    {
        // 배열 : 연속된 메모리, 요소 추가 안됨
        int[] arr = new int[] { 1, 2, 3 };
        //arr.Add(10); // error


        // 동적 배열 : 크기 변경이 가능하다. 요소 추가 가능. 연속된 메모리 사용
        // => object 기반 컬렉션, 타입 안정성이 좋지 않다.
        ArrayList c1 = new ArrayList();
        c1.Add("AA");
        c1.Add(10); // ok.. object 로 저장.!



        // List<T> : Generic 버전의 동적 배열. ArrayList 의 Generic 버전
        // => 연속된 메모리
        // => 검색 속도 빠르고, 캐쉬 적중률이 높다.
        List<int> c2 = new List<int>();
        c2.Add(10);
        //c2.Add("AA"); // error
        //c2.AddFisrt(20); // error


        // LinkedList<T> : 모든 요소가 떨어진 메모리
        //                  삽입삭제가 빠르다.
        //                  검색은 연속된 메모리 보다 느리다.
        LinkedList<int> c3 = new LinkedList<int>();
        c3.AddFirst(10);
        c3.AddLast(10);


        //============================
        // object 기반도 아니고, generic 도 아닌 
        // 특정 타입을 위한 컬렉션도 있습니다.(C# 1.0 때 사용하던것)
        // => 지금은 generic 사용하면 됩니다

        // System.Collections.Specialized;
        StringDictionary d = new StringDictionary();


        // System.Collections.Concurrent
        ConcurrentStack<int> cs = new ConcurrentStack<int>();
        cs.Push(10);

    }
}
