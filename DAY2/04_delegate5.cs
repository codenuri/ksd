using System;

// Func, Action
/*
// Generic 으로 delegate 만들기
delegate TResult Func<TResult>();
delegate TResult Func<T1, TResult>( T1 arg1);
delegate TResult Func<T1, T2, TResult>(T1 arg1, T2 arg2);
delegate TResult Func<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3);

// 반환타입이 void 인 함수를 위한 범용적 delegate 타입
delegate void Action();
delegate void Action<T1>(T1 arg1);
delegate void Action<T1, T2>(T1 arg1, T2 arg2);
*/

class Program
{
    public static int Foo() { Console.WriteLine("Foo"); return 0; }
    public static double Goo() { Console.WriteLine("Goo"); return 0; }
    public static double Hoo(string s) { Console.WriteLine("Hoo"); return 0; }

    public static void Main()
    {
        Func<int>    f1 = Foo;
        Func<double> f2 = Goo;
        Func<string, double> f3 = Hoo;

        Action f4 = F1;
        Action<int> f5 = F2;
    }

    public static void F1() { Console.WriteLine("F1"); }
    public static void F2(int a) { Console.WriteLine("F2"); }

}
