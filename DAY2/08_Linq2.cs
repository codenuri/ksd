using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] arr = { "kimmm", "park", "choi", "lee", "jung" };

        // Fluent Syntax : Where, OrderBy, Select
        /*
        var names = arr.Where(s => s.Contains('i'))
                       .OrderBy(s => s.Length)
                       .Select(s => s.ToUpper());
        */

        // 아래 코드는 위와 동일합니다. 컴파일러가 위 코드로 변경합니다.
        // => 마치 SQL 문 처럼 보입니다.
        var names = from s in arr where (s.Contains('i')) select s.ToUpper();


        foreach (var n in names)
        {
            Console.WriteLine(n);
        }

    }
}
