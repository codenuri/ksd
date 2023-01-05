using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 핵심 : LINQ 의 실행 결과

        // 1. 순차열이 아닌 값을 반환하는 질의 연산자
        int ret = numbers.First();
        Console.WriteLine(ret);


        // 2. 순차열을 반환(결과가 여러개)하는 질의
        // => 반환 타입은 "IEnumerable<T>" 입니다.
        // var result = numbers.Take(3);

        IEnumerable<int> result = numbers.Take(3);


        // result 내용을 열거 하려면
        // 1. foreach
        foreach (int n in result)
            Console.WriteLine(n);


        // 2. 반복자를 직접꺼내서 사용해도 됩니다.
        // => 위 "foreach" 의 원리는 결국 아래 코드와 동일합니다.
        var it = result.GetEnumerator();

        while( it.MoveNext() )
            Console.WriteLine(it.Current);


    }
}
