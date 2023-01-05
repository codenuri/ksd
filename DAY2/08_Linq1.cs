using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 홀수를 출력하는 방법
        // 1. foreach 또는 반복자 사용
        foreach( var n in arr )
        {
            if ( n % 2 == 1)
                Console.WriteLine(n);
        }

        // 2. Linq 를 사용. ( Language INtegrated Query )
        // Where : arr의 모든 요소를 단항 조건자 함수에 보내서 참을 반환하는 것만 선택
        //var odds = arr.Where(조건자함수);

        // var odds = arr.Where(Foo);  // 함수를 직접 전달하는 경우
        
        var odds = arr.Where( n => n % 2 == 1);    // 람다 표현식을 사용하는 경우

        foreach (var n in odds)
        {       
            Console.WriteLine(n);
        }
    }

    public static bool Foo(int n) {  return n % 2 == 1; }
}
