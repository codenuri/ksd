using System;

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = 20;
        int n3 = 30;

        // 1. 표준 출력
        Console.WriteLine("n1 = {0}, n2 = {1}, n3 = {2}", n1, n2, n3);

        // 2. C# 6.0 보간문자열(interpolated string) - $
        Console.WriteLine($"n1 = {n1}, n2 = {n2}, n3 = {n3}");

        // 3. 축자 문자열 리터럴(verbatim string literal ) - @
        // "\" 를 특수 문자가 아닌 일반 문자로 처리 해달라.
        Console.WriteLine("\\\\.\\pipe\\NamedPipe");
        Console.WriteLine(@"\\.\pipe\NamedPipe");

        // 4. 표준 입력
        // Console 클래스의 ReadLine 함수 사용
        //        string s = Console.ReadLine(); // enter 키를 입력할때 입력 종료
        //        Console.WriteLine(s);

        // 5. 입력 버퍼를 사용하지 않고 바로 입력( enter 없이 입력)

        ConsoleKeyInfo k = Console.ReadKey();  // enter 없이 한문자 입력

        char c = k.KeyChar;

        Console.WriteLine($"{c}");

        // 핵심 : 입출력 관련 모든 것은 "Console" 클래스의
        // static method 에서 찾으세요
    }
}




