// using

// 1. 확장자는 .cs
// 2. 컴파일러는 csc.exe
//     ==> csc 01_hello.cs
//     ==> csc /target:library 01_hello.cs => .dll(어셈블리)
//     ==> IDE 환경에서는 "CTRL + F5" 사용

// 3. 기본 모양 

// 4. 표준 출력 방법
using System; // C# 의 모든 클래스는 "System" 이름 공간에 있습
              // 니다. System 없이 사용 하겠다는 의미.
using static System.Console; // C# 6.0 추가 문법

class Program
{
    static void Main(string[] args)
    {
        // System : namespace 이름
        // Console: 클래스 이름
        // WriteLine : Console 클래스의 static method
        System.Console.WriteLine("Hello, C#");

        // using System 이 있으면 아래 처럼 가능.
        Console.WriteLine("Hello, C#");

        // using static System.Console 있으면 아래 처럼 가능
        // C# 6.0 에서 추가(현재 최신은 10.0)
        WriteLine("Hello, C#");
    }
}













// OS  : windows/linux      다양한 OS
    
// CPU : Intel              ARM





