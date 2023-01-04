using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Point 는 클래스이므로 reference 타입입니다.
class Point
{
    public int x;
    public int y;
    public Point(int a, int b) { x = a; y = b; }
}
class Program
{
    // call by value 입니다.
    public static void F1(Point p1)     { p1.x = 10; }
    public static void F2(ref Point p1) { p1.x = 10; }

    public static void Main()
    {
        // Point p = new Point(1, 2);

        // F1(p);  // p의 값(객체의 주소)을 p1 으로 복사하게 됩니다.
        // 주소값만 복사되므로, 결국 같은 객체를 가리키게 됩니다.
        // F2(ref p); // 위 코드와 동일한 효과 입니다.

        // 핵심 1. reference type 의 객체를 call by value로 전달하면
        // => 원본 객체의 상태 변경은 가능합니다.
        // => 하지만 새로운 객체를 담아 올수는 없습니다.
        // F3(p);  

        // 핵심 2. 참조 변수에 새로운 객체를 담아 오려면 
        //         참조 변수를 다시 참조로 전달해야 합니다.

        Point p = new Point(1, 2);

        F4(ref p); // 객체의 주소가 아닌 참조 변수 p의 메모리 주소를 전달.

        Console.WriteLine(p.x); // ??
    }

    public static void F4(ref Point p1)
    {
        // 현재 p1 은 Main 에서 만든 객체의 참조(주소)가 아니라!!
        // 참조 변수의 참조(p 의 주소) 입니다.
        // 아래 코드는 
        // C++언어 : *p1 = new Point(10,20);
        //           p1이 가리키는 메모리 = new Point(10,20)
        p1 = new Point(10, 20);
            // => 새로 만든 객체의 주소를 p1에 넣는 코드가 아닙니다.
            // => p1이 가리키는 곳(main 함수의 p참조변수)에 새로운 객체의
            //    주소를 넣게 됩니다.
         
    }

    public static void F3(Point p1)
    {
        p1 = new Point(10, 20);
    }
}