using System;

// Generic 클래스 : Collection 클래스 만들때 주로 사용

class Point<T>
{
    public T x;
    public T y;

    // default(T) : T 타입의 디폴트값
    //              T 가 참조 타입이면 null, primitive type 이면 0
    public Point(T a = default(T), T b = default(T)) { x = a; y = b; }
}

class Generic1
{
    public static void Main()
    {
        Point<int> p1 = new Point<int>(1, 1);
        Point<double> p2 = new Point<double>(1.2, 1.3);
    }
}
