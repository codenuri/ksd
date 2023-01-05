using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // MySelect() 를 만들어 봅시다
        var result  = arr.MySelect(n => n * 10); // MySelect(arr, 조건자함수)

        foreach (int n in result)
            Console.WriteLine(n); // 10, 20, 30, 40 
    }
}
// LINQ 는 
// 1. 모든 Collection 에 대해 확장 메소드 문법으로 만들었습니다.
// 2. 대부분 COROUTINE 로 만들어져 있습니다.

static class MyArrayExt     // 클래스이름은 아무 이름이나 상관없습니다.
{
    public static IEnumerable<int> MySelect(this Array arr, Func<int, int> f)
    {
        foreach (int e in arr)
            //yield return e;  // 배열의 요소를 그냥 반환
            yield return f(e); // 조건자 함수의 결과를 반환
    }
}

// 도전 과제 : var result = arr.MyTake(3); 만들어 보세요.