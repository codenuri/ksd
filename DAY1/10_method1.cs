using System;

// 핵심 . 인자 전달 방식과 참조 타입 => 아주 중요하니 반드시 이해 하세요.

class Program
{
    // call by value : 인자로 전달한 n1의 복사본 n을 새롭게 생성
    public static void f1(int n) { n = 20; } // 복사본 변경, n1은 변경안됨

    // call by reference
    public static void f2(ref int n) { n = 20; }

    // out parameter : 인자로 받은 것은 쓰기 위한 용도로만 사용
    public static void f3(out int n) 
    {
//        int a = n; // error
        n = 20; 
    }

    public static void Main()
    {
        int n1 = 10;
        int n2 = 20;
        int n3;

        f1(n1);
        f2(ref n2); // n2를 참조로 전달하겠다는 의미.

        // out parameter 는 초기화 되지 않은 변수 전달 가능합니다.
//      f2(ref n3); // error
        f3(out n3); // ok.

        Console.WriteLine($"{n1} {n2}"); // 10, 20
    }


}