using System;

// boxing / unboxing 개념

// 모든 타입의 비교 함수의 이름을 동일하게 할수 있도록 규칙을 만들자

// C#
// 1. 여러 타입에서 사용되는 공통의 함수를 정의 하는 인터페이스가 먼저 설계 되어 있고
// 2. 타입을 만들때, 각각의 인터페이스 구현하는 방식으로 타입 설계

struct Point : IComparable
{ 
    public int x;
    public int y;
    public Point(int a = 0, int b = 0) { x = a; y = b; }

    // 아래 코드는 Boxing 현상 때문에 성능저하가 있는 메소드 입니다.
    public int CompareTo(object obj) // object obj = p2 이므로 
    {                                // boxing 이 됩니다. 복사본이 힙에 생성됩니다

        // Point 의 고유 멤버에 접근하려면 Point 타입으로 캐스팅 해야 합니다.
        Point pt = (Point)obj;

        // x로 만 크기 비교
        return x.CompareTo(pt.x);
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(1, 1); // stack 에 있는 객체

        // Point 객체 2개의 크기를 비교 하려고 합니다.
        int ret = p1.CompareTo(p2);
    }
}


/*
        int n1 = 0;
        int n2 = 10;

        // C# 에서 객체를 비교하는 2가지 방법
        // 1. 비교 연산자 사용(<, >등)
        // 2. CompareTo() 멤버 함수 사용
        Console.WriteLine(n1 < n2);
        Console.WriteLine(n1.CompareTo(n2));
*/