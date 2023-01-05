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
        // 딕셔너리 : 키값으로 value 를 보관하는 컬렉션
        Dictionary<string, string> d = new Dictionary<string, string>();

        // 1. 요소 넣기
        d.Add("sun", "일요일");

        d["mon"] = "월요일"; // [] 연산도 가능

        
        Console.WriteLine(d["mon"]); // "월요일"

        // 2. 키값이 있는지만 확인
        if (d.ContainsKey("mon"))
            Console.WriteLine("요소 있음");


    }
}
