using System;

// 핵심 : this를 사용한 다른 생성자 호출

class Point
{
    public int x;
    public int y;

    public Point(int a, int b) 
    { 
        x = a; y = b; Console.WriteLine("Point(int, int)"); 
    }
    
    public Point()  : this(0,0) 
    { 
//      Point(0, 0);  // 생성자에서 다른 생성자 호출 ?
                      // => 이렇게 하면 안됩니다.
                      // => 이 표기법을 허용하면 기반 클래스 생성자가 2회 호출
                      //    되는 문제점이 생기게 됩니다.
                      // => 그래서, 다양한 객체지향 언어가 각각 자신들만의 방식으로
                      //    생성자에서 다른 생성자를 호출하는 방식을 제공합니다.

        Console.WriteLine("Point()"); 
    }
}
 

class Program
{
    public static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point();

        Console.WriteLine($"{p2.x}, {p2.y}");
    }
}