using System;

// 추상 클래스 와 추상 메소드

// 추상 클래스 : 추상 메소드가 한개 이상 있는 클래스
// 의도 : 특정 메소드를 반드시 만들라고 지시 하는것 - 약속!
abstract class Shape
{
    public int color = 0;
    public abstract void Draw(); // 추상 메소드
                                 // 특징 구현이 없다..
}

class Rect : Shape
{
    // Shape 로 부터 물려 받는 추상 메소드의 구현을 제공하지 않으면 
    // Rect 도 추상이 됩니다.

    // Rect 를 사용할수 있게 하려면 반드시 Draw() 구현을 제공해야 합니다.
    public override void Draw() { Console.WriteLine("Draw Rect"); }
}

class Program
{
    public static void Main()
    {
//      Shape s = new Shape(); // error. 추상 클래스는 객체를 만들수 없다.
        Rect  p = new Rect();
    }
}