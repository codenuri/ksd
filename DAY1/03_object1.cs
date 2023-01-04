using System;

// 핵심 2. 모든 것은 객체이다.

// C/C++ 은 struct 또는 class로 만든 타입만 멤버가 있다.
//int   n; // n 에는 멤버가 없다. 
//Point p; // p 에는 멤버가 있다. 

// java 도 유사
//int n1;     // n1은 멤버가 없다.
//Integer n2 = new Integer(); // n2는 멤버가 있다.

// C#의 모든 것은 객체이다.

class Program
{
    public static void Main()
    {
        // 핵심 1. 10 도 멤버함수(메소드)가 있다.
        string s = 10.ToString(); // 10 => "10" 으로 변환 한것
                                  // 10 이라는 객체의 instance method호출
        Console.WriteLine(s); // "10"

        // 핵심 2. 문자열을 정수로 변경하기
        string s1 = "10";
        int n1 = int.Parse(s1); // int 타입의 static method

        // 핵심 3. 사용자에게 정수 입력 받기
        // => 문자열을 입력 받은후 정수로 변경하는 것
        int n2 = int.Parse( Console.ReadLine() );
        Console.WriteLine(n2);

     //   n2.ToString();
    }
}








