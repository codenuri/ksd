using System;

// 안전한 코드를 만들기 위한 문법들

class Program
{
    public static void Main()
    {
        int n;
        Console.WriteLine(n);  // error. 초기화 되지 않은 변수는  출력할수 없습니다.
                               //  C/C++ 은 쓰레기값!!


        int n0 = int.MaxValue + 1; // error. overflow 발생

        int n1 = int.MaxValue;  // ok
        int n2 = n1 + 1;        // error 아님. 변수이므로 컴파일 시간에는
                                // 값 조사가 안되므로.

        int n3 = checked(n1 + 1); // overflow 발생시 실행시간에 예외를 던져 달라
                                  // 안전한 코드를 위한 도구.
                               
        // 또는 컴파일 시에 /checked 옵션을 전달하면 모든 연산에 대해서
        // 오버 플로우 발생시 예외 발생.
    }
}