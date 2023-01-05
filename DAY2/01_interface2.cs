using System;

// 추상 클래스 : 지켜야 하는 규칙(추상 메소드) + 다른 멤버도 가진 경우.
// 인터 페이스 : 지켜야 하는 규칙(추상 메소드) 만 가진것

interface IShape
{
    // 이 안에는 파생 클래스가 반드시 만들어야 하는 규칙(메소드 모양)만
    // 담을수 있습니다.
    // 따라서, 메소드 만들때 abstract 라는 키워드 사용하지 않습니다
    void Draw();
}

class Rect : IShape
{
}

class Program
{
    public static void Main()
    {
        IShape p = new Rect();
        p.Draw();
    }
}
