using System;

class Program
{
    public static int Add(int a, int b) {  return a + b; }

    public static void Main()
    {
        int v1 = 10;

        // 1. 함수를 만들어서 delegate 에 등록.
        Func<int, int, int> plus = Add;

        // 2. 람다표현식을 사용해서 익명의 함수를 delegate 에 등록
        // 람다표현식 표기법 : (인자리스트) => { 함수 구현 }

        // Func<int, int, int> plus2 = (int a, int b) => {  return a + b; };
        // Func<int, int, int> plus2 = (a, b) => { return a + b; };
        Func<int, int, int> plus2 = (a, b) => a + b; // C#
//      Func<int, int, int> plus2 = $0 + $1;         // Swift

        Console.WriteLine($"{plus2(10,20)}");
    }
}